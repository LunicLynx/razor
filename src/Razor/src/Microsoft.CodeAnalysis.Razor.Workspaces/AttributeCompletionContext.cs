﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.Language;

namespace Microsoft.VisualStudio.Editor.Razor;

public sealed class AttributeCompletionContext
{
    public TagHelperDocumentContext DocumentContext { get; }
    public IEnumerable<string> ExistingCompletions { get; }
    public string CurrentTagName { get; }
    public string? CurrentAttributeName { get; }
    public IEnumerable<KeyValuePair<string, string>> Attributes { get; }
    public string? CurrentParentTagName { get; }
    public bool CurrentParentIsTagHelper { get; }
    public Func<string, bool> InHTMLSchema { get; }

    public AttributeCompletionContext(
        TagHelperDocumentContext documentContext,
        IEnumerable<string> existingCompletions,
        string currentTagName,
        string? currentAttributeName,
        IEnumerable<KeyValuePair<string, string>> attributes,
        string? currentParentTagName,
        bool currentParentIsTagHelper,
        Func<string, bool> inHTMLSchema)
    {
        DocumentContext = documentContext ?? throw new ArgumentNullException(nameof(documentContext));
        ExistingCompletions = existingCompletions ?? throw new ArgumentNullException(nameof(existingCompletions));
        CurrentTagName = currentTagName ?? throw new ArgumentNullException(nameof(currentTagName));
        CurrentAttributeName = currentAttributeName;
        Attributes = attributes ?? throw new ArgumentNullException(nameof(attributes));
        CurrentParentTagName = currentParentTagName;
        CurrentParentIsTagHelper = currentParentIsTagHelper;
        InHTMLSchema = inHTMLSchema ?? throw new ArgumentNullException(nameof(inHTMLSchema));
    }
}
