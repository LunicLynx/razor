﻿// <auto-generated/>
#pragma warning disable 1591
namespace AspNetCore
{
    #line hidden
    using TModel = global::System.Object;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 4 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::DivTagHelper __DivTagHelper;
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
// language=Route
#nullable restore
#line 3 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
global::System.Object __typeHelper = "*, AppCode";

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
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
#nullable restore
#line 25 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
                                         __o = Name;

#line default
#line hidden
#nullable disable
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            __DivTagHelper = CreateTagHelper<global::DivTagHelper>();
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/RazorPagesWithoutModel.cshtml"
            
    public IActionResult OnPost(Customer customer)
    {
        Name = customer.Name;
        return Redirect("~/customers/inlinepagemodels/");
    }

    public string Name { get; set; }

    public class Customer
    {
        public string Name { get; set; }
    }

#line default
#line hidden
#nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel>)PageContext?.ViewData;
        public TestFiles_IntegrationTests_CodeGenerationIntegrationTest_RazorPagesWithoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
