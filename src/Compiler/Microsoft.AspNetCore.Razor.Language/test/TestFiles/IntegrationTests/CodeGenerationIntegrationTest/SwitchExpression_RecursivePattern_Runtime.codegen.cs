﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/SwitchExpression_RecursivePattern.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05b5403c90038450308965e66938c662bb875731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_SwitchExpression_RecursivePattern_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/SwitchExpression_RecursivePattern.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b5403c90038450308965e66938c662bb875731", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/SwitchExpression_RecursivePattern.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_SwitchExpression_RecursivePattern_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/SwitchExpression_RecursivePattern.cshtml"
 switch (DateTimeOffset.UtcNow)
{
    case { Year: 2022 }:

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>Property expressions are supported by the razor syntax in the year 2022.</strong>\r\n");
#nullable restore
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/SwitchExpression_RecursivePattern.cshtml"
        break;
    case [{ Test: true }]:
        break;
    case ({ Test: { Nested.Pattern: global::Qualifier } }):
        break;
    case global::Test:
        break;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
