﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __o = global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                   ParentValue

#line default
#line hidden
#nullable disable
            );
            __o = global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, callback: UpdateValue, value: ParentValue), ParentValue);
        }
        #pragma warning restore 1998
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public string ParentValue { get; set; } = "hi";

    public void UpdateValue(string value) => ParentValue = value;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
