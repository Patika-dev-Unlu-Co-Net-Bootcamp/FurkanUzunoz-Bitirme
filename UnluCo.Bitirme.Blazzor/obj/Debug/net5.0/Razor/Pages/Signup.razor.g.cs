#pragma checksum "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ba7f68fa6d4dd01a6a6d68530cedb5bafcc3a61"
// <auto-generated/>
#pragma warning disable 1591
namespace UnluCo.Bitirme.Blazzor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Blazzor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\_Imports.razor"
using Blazzor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
using Blazzor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
using Blazzor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Signup")]
    public partial class Signup : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                                        SignUp

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "<div><br><br><br><br><br></div>\r\n    ");
                __builder2.AddMarkupContent(5, "<div><h3 style=\"font-weight:bold; color:purple\">??nl??Co Bitirme</h3></div>\r\n    ");
                __builder2.AddMarkupContent(6, "<div><br></div>\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-12 row");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "class", "form-control col-12");
                __builder2.AddAttribute(11, "placeholder", "email address");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                                                  user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Username = __value, user.Username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-12 row");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "class", "form-control col-12");
                __builder2.AddAttribute(19, "placeholder", "email address");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                                                  user.Gsm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Gsm = __value, user.Gsm));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-12 row");
                __builder2.OpenElement(25, "input");
                __builder2.AddAttribute(26, "class", "form-control col-12");
                __builder2.AddAttribute(27, "placeholder", "email address");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                                                  user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-12 row");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "class", "form-control col-12");
                __builder2.AddAttribute(35, "placeholder", "email address");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                                                  user.Gender

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Gender = __value, user.Gender));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "col-12 row");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "class", "form-control col-12");
                __builder2.AddAttribute(43, "placeholder", "email address");
                __builder2.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                                                  user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    \r\n    ");
                __builder2.AddMarkupContent(47, "<div class=\"col-12 row\"><span class=\"col-12\"></span>\r\n        <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Login\"></div>\r\n    <br>\r\n    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-12 row");
                __builder2.AddAttribute(50, "style", "text-align:left; font-weight:bold");
                __builder2.OpenElement(51, "span");
                __builder2.AddAttribute(52, "class", "col-12");
                __builder2.AddContent(53, 
#nullable restore
#line 44 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
                              Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Signup.razor"
       
    private User user;
    public string Message { get; set; }
    private async Task SignUp()
    {
        var result = await userService.CreateAccount(user);
        Message = result.message;

    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
