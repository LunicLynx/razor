﻿// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_EnumTagHelpers_DesignTime
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper;
        private global::TestNamespace.CatchAllTagHelper __TestNamespace_CatchAllTagHelper;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 1 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
global::System.Object __typeHelper = "*, TestAssembly";

#line default
#line hidden
#nullable disable
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
  
    var enumValue = MyEnum.MyValue;

#line default
#line hidden
#nullable disable
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
#nullable restore
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = MyEnum.MyValue;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
#nullable restore
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
         __o = MyEnum.MySecondValue;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
#nullable restore
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = global::Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestTagHelperDescriptors.MyEnum.MyValue;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = global::Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestTagHelperDescriptors.MyEnum.MySecondValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_CatchAllTagHelper.CatchAll = global::Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestTagHelperDescriptors.MyEnum.MyValue;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
            __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
#nullable restore
#line 11 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_InputTagHelper.Value = enumValue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/EnumTagHelpers.cshtml"
__TestNamespace_CatchAllTagHelper.CatchAll = enumValue;

#line default
#line hidden
#nullable disable
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
