﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;

namespace Microsoft.AspNetCore.Razor.OmniSharpPlugin;

internal sealed class OmniSharpProjectSnapshot
{
    internal readonly IProjectSnapshot InternalProjectSnapshot;

    internal OmniSharpProjectSnapshot(IProjectSnapshot projectSnapshot)
    {
        InternalProjectSnapshot = projectSnapshot;
    }

    public string FilePath => InternalProjectSnapshot.FilePath;

    public IEnumerable<string> DocumentFilePaths => InternalProjectSnapshot.DocumentFilePaths;

    public RazorConfiguration Configuration => InternalProjectSnapshot.Configuration;

    public ProjectWorkspaceState ProjectWorkspaceState => InternalProjectSnapshot.ProjectWorkspaceState;

    public OmniSharpDocumentSnapshot GetDocument(string filePath)
    {
        var documentSnapshot = InternalProjectSnapshot.GetDocument(filePath);
        if (documentSnapshot is null)
        {
            return null;
        }

        var internalDocumentSnapshot = new OmniSharpDocumentSnapshot(documentSnapshot);
        return internalDocumentSnapshot;
    }

    internal static OmniSharpProjectSnapshot Convert(IProjectSnapshot projectSnapshot)
    {
        if (projectSnapshot is null)
        {
            return null;
        }

        return new OmniSharpProjectSnapshot(projectSnapshot);
    }

    public static OmniSharpProjectSnapshot CreateForTest(object projectSnapshot)
    {
        if (projectSnapshot is IProjectSnapshot stronglyTypedSnapshot)
        {
            return new OmniSharpProjectSnapshot(stronglyTypedSnapshot);
        }

        throw new ArgumentException($"Snapshot is not of type {typeof(IProjectSnapshot).FullName}", nameof(projectSnapshot));
    }
}
