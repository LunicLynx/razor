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
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using N;

#line default
#line hidden
#nullable disable
    public partial class TestComponent<TParam> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
global::System.Object TParam = null!;

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
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            var __typeInference_CreateTestComponent_0 = global::__Blazor.Test.TestComponent.TypeInference.CreateTestComponent_0(__builder, -1, -1, 
#nullable restore
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
                           1

#line default
#line hidden
#nullable disable
            , -1, (context) => (__builder2) => {
#nullable restore
#line 14 "x:\dir\subdir\Test\TestComponent.cshtml"
   __o = context.I1.MyClassId;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "x:\dir\subdir\Test\TestComponent.cshtml"
                           __o = context.I2.MyStructId;

#line default
#line hidden
#nullable disable
            }
            );
            __o = __typeInference_CreateTestComponent_0.
#nullable restore
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
               InferParam

#line default
#line hidden
#nullable disable
            ;
#nullable restore
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.TestComponent<>);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    [Parameter]
    public TParam InferParam { get; set; }

    [Parameter]
    public RenderFragment<(MyClass I1, MyStruct I2, TParam P)> Template { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static global::Test.TestComponent<TParam> CreateTestComponent_0<TParam>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TParam __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<(global::N.MyClass I1, global::N.MyStruct I2, TParam P)> __arg1)
        {
        __builder.OpenComponent<global::Test.TestComponent<TParam>>(seq);
        __builder.AddAttribute(__seq0, "InferParam", __arg0);
        __builder.AddAttribute(__seq1, "Template", __arg1);
        __builder.CloseComponent();
        return default;
        }
    }
}
#pragma warning restore 1591
