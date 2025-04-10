﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.AspNetCore.Razor.LanguageServer.Protocol;
using Microsoft.AspNetCore.Razor.LanguageServer.Test;
using Microsoft.AspNetCore.Razor.LanguageServer.Test.Common;
using Microsoft.AspNetCore.Razor.Test.Common;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Microsoft.CodeAnalysis.Razor.Workspaces.Extensions;
using Microsoft.CodeAnalysis.Text;
using Microsoft.VisualStudio.LanguageServer.Protocol;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Formatting;

public class FormattingDiagnosticValidationPassTest : LanguageServerTestBase
{
    public FormattingDiagnosticValidationPassTest(ITestOutputHelper testOutput)
        : base(testOutput)
    {
    }

    [Fact]
    public async Task ExecuteAsync_LanguageKindCSharp_Noops()
    {
        // Arrange
        var source = SourceText.From(@"
@code {
    public class Foo { }
}
");
        using var context = CreateFormattingContext(source);
        var badEdit = new TextEdit()
        {
            NewText = "@ ",
            Range = new Range { Start = new Position(0, 0), End = new Position(0, 0) }
        };
        var input = new FormattingResult(new[] { badEdit }, RazorLanguageKind.CSharp);
        var pass = GetPass();

        // Act
        var result = await pass.ExecuteAsync(context, input, DisposalToken);

        // Assert
        Assert.Equal(input, result);
    }

    [Fact]
    public async Task ExecuteAsync_LanguageKindHtml_Noops()
    {
        // Arrange
        var source = SourceText.From(@"
@code {
    public class Foo { }
}
");
        using var context = CreateFormattingContext(source);
        var badEdit = new TextEdit()
        {
            NewText = "@ ",
            Range = new Range { Start = new Position(0, 0), End = new Position(0, 0) }
        };
        var input = new FormattingResult(new[] { badEdit }, RazorLanguageKind.Html);
        var pass = GetPass();

        // Act
        var result = await pass.ExecuteAsync(context, input, DisposalToken);

        // Assert
        Assert.Equal(input, result);
    }

    [Fact]
    public async Task ExecuteAsync_NonDestructiveEdit_Allowed()
    {
        // Arrange
        var source = SourceText.From(@"
@code {
public class Foo { }
}
");
        using var context = CreateFormattingContext(source);
        var edits = new[]
        {
            new TextEdit()
            {
                NewText = "    ",
                Range = new Range{ Start = new Position(2, 0), End = new Position(2, 0) }
            }
        };
        var input = new FormattingResult(edits, RazorLanguageKind.Razor);
        var pass = GetPass();

        // Act
        var result = await pass.ExecuteAsync(context, input, DisposalToken);

        // Assert
        Assert.Equal(input, result);
    }

    [Fact]
    public async Task ExecuteAsync_DestructiveEdit_Rejected()
    {
        // Arrange
        var source = SourceText.From(@"
@code {
public class Foo { }
}
");
        using var context = CreateFormattingContext(source);
        var badEdit = new TextEdit()
        {
            NewText = "@ ", // Creates a diagnostic
            Range = new Range { Start = new Position(0, 0), End = new Position(0, 0) },
        };
        var input = new FormattingResult(new[] { badEdit }, RazorLanguageKind.Razor);
        var pass = GetPass();

        // Act
        var result = await pass.ExecuteAsync(context, input, DisposalToken);

        // Assert
        Assert.Empty(result.Edits);
    }

    private FormattingDiagnosticValidationPass GetPass()
    {
        var mappingService = new DefaultRazorDocumentMappingService(TestLanguageServerFeatureOptions.Instance, new TestDocumentContextFactory(), LoggerFactory);

        var client = Mock.Of<ClientNotifierServiceBase>(MockBehavior.Strict);
        var pass = new FormattingDiagnosticValidationPass(mappingService, client, LoggerFactory)
        {
            DebugAssertsEnabled = false
        };

        return pass;
    }

    private static FormattingContext CreateFormattingContext(SourceText source, int tabSize = 4, bool insertSpaces = true, string? fileKind = null)
    {
        var path = "file:///path/to/document.razor";
        var uri = new Uri(path);
        var (codeDocument, documentSnapshot) = CreateCodeDocumentAndSnapshot(source, uri.AbsolutePath, fileKind: fileKind);
        var options = new FormattingOptions()
        {
            TabSize = tabSize,
            InsertSpaces = insertSpaces,
        };

        var context = FormattingContext.Create(uri, documentSnapshot, codeDocument, options, TestAdhocWorkspaceFactory.Instance);
        return context;
    }

    private static (RazorCodeDocument, IDocumentSnapshot) CreateCodeDocumentAndSnapshot(SourceText text, string path, IReadOnlyList<TagHelperDescriptor>? tagHelpers = null, string? fileKind = default)
    {
        fileKind ??= FileKinds.Component;
        tagHelpers ??= Array.Empty<TagHelperDescriptor>();
        var sourceDocument = text.GetRazorSourceDocument(path, path);
        var projectEngine = RazorProjectEngine.Create(builder => builder.SetRootNamespace("Test"));
        var codeDocument = projectEngine.ProcessDesignTime(sourceDocument, fileKind, Array.Empty<RazorSourceDocument>(), tagHelpers);

        var documentSnapshot = new Mock<IDocumentSnapshot>(MockBehavior.Strict);
        documentSnapshot
            .Setup(d => d.GetImports())
            .Returns(ImmutableArray<IDocumentSnapshot>.Empty);
        documentSnapshot
            .Setup(d => d.GetGeneratedOutputAsync())
            .ReturnsAsync(codeDocument);
        documentSnapshot
            .Setup(d => d.Project.GetProjectEngine())
            .Returns(projectEngine);
        documentSnapshot
            .Setup(d => d.TargetPath)
            .Returns(path);
        documentSnapshot
            .Setup(d => d.Project.TagHelpers)
            .Returns(tagHelpers);
        documentSnapshot
            .Setup(d => d.FileKind)
            .Returns(fileKind);
        documentSnapshot
            .Setup(d => d.FilePath)
            .Returns(path);

        return (codeDocument, documentSnapshot.Object);
    }
}
