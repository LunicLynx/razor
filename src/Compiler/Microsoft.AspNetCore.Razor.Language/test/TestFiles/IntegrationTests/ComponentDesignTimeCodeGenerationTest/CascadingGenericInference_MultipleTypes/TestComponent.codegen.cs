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
            {
                global::__Blazor.Test.TestComponent.TypeInference.CreateParent_0_CaptureParameters(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                new System.Collections.Generic.Dictionary<int, string>()

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg0, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                                   DateTime.MinValue

#line default
#line hidden
#nullable disable
                , out var __typeInferenceArg_0___arg1);
                var __typeInference_CreateParent_0 = global::__Blazor.Test.TestComponent.TypeInference.CreateParent_0(__builder, -1, -1, __typeInferenceArg_0___arg0, -1, __typeInferenceArg_0___arg1, -1, (__builder2) => {
                    var __typeInference_CreateChild_1 = global::__Blazor.Test.TestComponent.TypeInference.CreateChild_1(__builder2, -1, __typeInferenceArg_0___arg1, __typeInferenceArg_0___arg0, __typeInferenceArg_0___arg0, -1, 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                             new[] { 'a', 'b', 'c' }

#line default
#line hidden
#nullable disable
                    );
                    __o = __typeInference_CreateChild_1.
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
           ChildOnlyItems

#line default
#line hidden
#nullable disable
                    ;
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.Child<,,,>);

#line default
#line hidden
#nullable disable
                }
                );
                __o = __typeInference_CreateParent_0.
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
        Data

#line default
#line hidden
#nullable disable
                ;
                __o = __typeInference_CreateParent_0.
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                           Other

#line default
#line hidden
#nullable disable
                ;
            }
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.Parent<,,>);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static global::Test.Parent<TKey, TValue, TOther> CreateParent_0<TKey, TValue, TOther>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.Dictionary<TKey, TValue> __arg0, int __seq1, TOther __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Test.Parent<TKey, TValue, TOther>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Other", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        return default;
        }

        public static void CreateParent_0_CaptureParameters<TKey, TValue, TOther>(global::System.Collections.Generic.Dictionary<TKey, TValue> __arg0, out global::System.Collections.Generic.Dictionary<TKey, TValue> __arg0_out, TOther __arg1, out TOther __arg1_out)
        {
            __arg0_out = __arg0;
            __arg1_out = __arg1;
        }
        public static global::Test.Child<TOther, TValue, TKey, TChildOnly> CreateChild_1<TOther, TValue, TKey, TChildOnly>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, TOther __syntheticArg0, System.Collections.Generic.Dictionary<TKey, TValue> __syntheticArg1, System.Collections.Generic.Dictionary<TKey, TValue> __syntheticArg2, int __seq0, global::System.Collections.Generic.ICollection<TChildOnly> __arg0)
        {
        __builder.OpenComponent<global::Test.Child<TOther, TValue, TKey, TChildOnly>>(seq);
        __builder.AddAttribute(__seq0, "ChildOnlyItems", __arg0);
        __builder.CloseComponent();
        return default;
        }
    }
}
#pragma warning restore 1591
