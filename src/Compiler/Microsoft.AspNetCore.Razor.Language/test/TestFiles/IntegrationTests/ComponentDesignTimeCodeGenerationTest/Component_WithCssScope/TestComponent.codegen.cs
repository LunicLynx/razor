// <auto-generated/>
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
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
#nullable disable
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
            __o = 
#nullable restore
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                             123

#line default
#line hidden
#nullable disable
            ;
            __builder.AddAttribute(-1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
                              myComponentReference = default(global::Test.TemplatedComponent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(global::Test.TemplatedComponent);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "x:\dir\subdir\Test\TestComponent.cshtml"
 if (DateTime.Now.Year > 1950)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "x:\dir\subdir\Test\TestComponent.cshtml"
                                      myElementReference = default(Microsoft.AspNetCore.Components.ElementReference);

#line default
#line hidden
#nullable disable
                                                                                    
    
            __o = global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "x:\dir\subdir\Test\TestComponent.cshtml"
                              myVariable

#line default
#line hidden
#nullable disable
            );
            __o = global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => myVariable = __value, myVariable);
#nullable restore
#line 14 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                              
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    ElementReference myElementReference;
    TemplatedComponent myComponentReference;
    string myVariable;

    void MethodRenderingMarkup(RenderTreeBuilder __builder)
    {
        for (var i = 0; i < 10; i++)
        {
            

#line default
#line hidden
#nullable disable
        __o = 
#nullable restore
#line 26 "x:\dir\subdir\Test\TestComponent.cshtml"
                            i

#line default
#line hidden
#nullable disable
        ;
#nullable restore
#line 26 "x:\dir\subdir\Test\TestComponent.cshtml"
                                   __o = i;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "x:\dir\subdir\Test\TestComponent.cshtml"
                                               
        }

        System.GC.KeepAlive(myElementReference);
        System.GC.KeepAlive(myComponentReference);
        System.GC.KeepAlive(myVariable);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
