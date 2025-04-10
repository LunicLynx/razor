﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

namespace Microsoft.AspNetCore.Razor.Language.Intermediate;

public sealed class TypeParameter
{
    public string ParameterName { get; set; }
    public string Constraints { get; set; }
}
