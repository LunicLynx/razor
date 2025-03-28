﻿/* --------------------------------------------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 * ------------------------------------------------------------------------------------------ */

import { EventEmitter } from 'events';
import * as vscode from 'vscode';
import {
    RequestHandler,
    RequestType,
} from 'vscode-jsonrpc';
import {
    GenericNotificationHandler,
    InitializeResult,
    LanguageClientOptions,
    State,
} from 'vscode-languageclient';
import {
    LanguageClient,
    ServerOptions,
} from 'vscode-languageclient/node';
import { RazorLanguage } from './RazorLanguage';
import { RazorLanguageServerOptions } from './RazorLanguageServerOptions';
import { resolveRazorLanguageServerOptions } from './RazorLanguageServerOptionsResolver';
import { resolveRazorLanguageServerTrace } from './RazorLanguageServerTraceResolver';
import { RazorLogger } from './RazorLogger';
import { TelemetryReporter } from './TelemetryReporter';

const events = {
    ServerStop: 'ServerStop',
};

export class RazorLanguageServerClient implements vscode.Disposable {
    private clientOptions!: LanguageClientOptions;
    private serverOptions!: ServerOptions;
    private client!: LanguageClient;
    private onStartListeners: Array<() => Promise<any>> = [];
    private onStartedListeners: Array<() => Promise<any>> = [];
    private eventBus: EventEmitter;
    private isStarted: boolean;
    private startHandle: Promise<void> | undefined;
    private stopHandle: Promise<void> | undefined;

    constructor(
        private readonly vscodeType: typeof vscode,
        private readonly languageServerDir: string,
        private readonly telemetryReporter: TelemetryReporter,
        private readonly logger: RazorLogger) {
        this.isStarted = false;

        this.setupLanguageServer();

        this.eventBus = new EventEmitter();
    }

    public get initializeResult(): InitializeResult | undefined {
        return this.client.initializeResult;
    }

    public updateTraceLevel() {
        const languageServerTrace = resolveRazorLanguageServerTrace(this.vscodeType);
        this.setupLanguageServer();
        this.logger.setTraceLevel(languageServerTrace);
    }

    public onStarted(listener: () => Promise<any>) {
        this.onStartedListeners.push(listener);
    }

    public onStart(listener: () => Promise<any>) {
        this.onStartListeners.push(listener);
    }

    public onStop(listener: () => any) {
        this.eventBus.addListener(events.ServerStop, listener);

        const disposable = new vscode.Disposable(() =>
            this.eventBus.removeListener(events.ServerStop, listener));
        return disposable;
    }

    public async start() {
        if (this.startHandle) {
            return this.startHandle;
        }

        let resolve: () => void = Function;
        let reject: (reason: any) => void = Function;
        this.startHandle = new Promise<void>((resolver, rejecter) => {
            resolve = resolver;
            reject = rejecter;
        });

        // Workaround https://github.com/Microsoft/vscode-languageserver-node/issues/472 by tying into state
        // change events to detect when restarts are occuring and then properly reject the Language Server
        // start listeners.
        let restartCount = 0;
        const didChangeStateDisposable = this.client.onDidChangeState((stateChangeEvent: { newState: any; oldState: any; }) => {
            if (stateChangeEvent.oldState === State.Starting && stateChangeEvent.newState === State.Stopped) {
                restartCount++;

                if (restartCount === 5) {
                    // Timeout, the built-in LanguageClient retries a hardcoded 5 times before giving up. We tie into that
                    // and then given up on starting the language server if we can't start by then.
                    reject('Server failed to start after retrying 5 times.');
                }
            } else if (stateChangeEvent.newState === State.Running) {
                restartCount = 0;
            }
        });

        try {
            this.logger.logMessage('Starting Razor Language Server...');
            await this.client.start();
            this.logger.logMessage('Server started, waiting for client to be ready...');
            this.isStarted = true;
            for (const listener of this.onStartListeners) {
                await listener();
            }

            // Succesfully started, notify listeners.
            resolve();

            this.logger.logMessage('Server ready!');
            for (const listener of this.onStartedListeners) {
                await listener();
            }

            // We don't want to track restart management after the server has been initially started,
            // the language client will handle that.
            didChangeStateDisposable.dispose();
        } catch (error) {
            vscode.window.showErrorMessage(
                'Razor Language Server failed to start unexpectedly, ' +
                'please check the \'Razor Log\' and report an issue.');

            this.telemetryReporter.reportErrorOnServerStart(error as Error);
            reject(error);
        }

        return this.startHandle;
    }

    public async sendRequest<TResponseType>(method: string, param: any) {
        if (!this.isStarted) {
            throw new Error('Tried to send requests while server is not started.');
        }

        return this.client.sendRequest<TResponseType>(method, param);
    }

    public async onRequestWithParams<P, R, E>(method: RequestType<P, R, E>, handler: RequestHandler<P, R, E>) {
        if (!this.isStarted) {
            throw new Error('Tried to bind on request logic while server is not started.');
        }

        this.client.onRequest(method, handler);
    }

    public onNotification(method: string, handler: GenericNotificationHandler) {
        if (!this.isStarted) {
            throw new Error('Tried to bind on notification logic while server is not started.');
        }

        this.client.onNotification(method, handler);
    }

    public dispose() {
        this.logger.logMessage('Disposing Razor Language Server.');

        this.isStarted = false;
        this.startHandle = undefined;
        this.eventBus.emit(events.ServerStop);
    }

    public async stop() {
        let resolve: () => void = Function;
        let reject: (reason: any) => void = Function;
        this.stopHandle = new Promise<void>((resolver, rejecter) => {
            resolve = resolver;
            reject = rejecter;
        });

        if (!this.startHandle) {
            reject(new Error('Cannot stop Razor Language Server as it is already stopped.'));
        }

        this.logger.logMessage('Stopping Razor Language Server.');

        try {
            if (this.client) {
                await this.client.stop();
            }

            this.dispose();

            resolve();
        } catch (error) {
            vscode.window.showErrorMessage(
                'Razor Language Server failed to stop correctly, ' +
                'please check the \'Razor Log\' and report an issue.');

            reject(error);
        }

        return this.stopHandle;
    }

    private setupLanguageServer() {
        const languageServerTrace = resolveRazorLanguageServerTrace(this.vscodeType);
        const options: RazorLanguageServerOptions = resolveRazorLanguageServerOptions(this.vscodeType, this.languageServerDir, languageServerTrace, this.logger);

        this.clientOptions = {
            outputChannel: options.outputChannel,
            documentSelector: [ { language: RazorLanguage.id, pattern: RazorLanguage.globbingPattern } ],
        };

        const args: string[] = [];
        let command = options.serverPath;
        if (options.serverPath.endsWith('.dll')) {
            this.logger.logMessage('Razor Language Server path is an assembly. ' +
                'Using \'dotnet\' from the current path to start the server.');

            command = 'dotnet';
            args.push(options.serverPath);
        }

        this.logger.logMessage(`Razor language server path: ${options.serverPath}`);

        args.push('-lsp');
        args.push('--trace');

        this.telemetryReporter.reportTraceLevel(options.trace);

        args.push(options.trace.toString());

        if (options.debug) {
            this.telemetryReporter.reportDebugLanguageServer();

            this.logger.logMessage('Debug flag set for Razor Language Server.');
            args.push('--debug');
        }

        this.serverOptions = { command, args };
        this.client = new LanguageClient('razorLanguageServer', 'Razor Language Server', this.serverOptions, this.clientOptions);
    }
}
