#pragma checksum "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5188d7890a6af2819d4ca08bc98a880e057877"
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
#line 4 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
using Blazzor.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
using Blazzor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
                                        ValidateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<div><br><br><br><br><br></div>\r\n    ");
                __builder2.AddMarkupContent(6, "<div><h3 style=\"font-weight:bold; color:purple\">ÜnlüCo Bitirme</h3></div>\r\n    ");
                __builder2.AddMarkupContent(7, "<div><br></div>\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col-12 row");
                __builder2.OpenElement(10, "input");
                __builder2.AddAttribute(11, "class", "form-control col-12");
                __builder2.AddAttribute(12, "placeholder", "email address");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
                                                  user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    <br>\r\n    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-12 row");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "password");
                __builder2.AddAttribute(20, "class", "form-control col-12");
                __builder2.AddAttribute(21, "placeholder", "password");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
                                                                  user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    <br>\r\n    ");
                __builder2.AddMarkupContent(25, "<div class=\"col-12 row\"><span class=\"col-12\"></span>\r\n        <input type=\"submit\" class=\"form-control col-6 btn btn-primary\" value=\"Login\">\r\n        <a href=\"/Signup\" class=\"col-3\">Sign up</a></div>\r\n    <br>\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-12 row");
                __builder2.AddAttribute(28, "style", "text-align:left; font-weight:bold");
                __builder2.OpenElement(29, "span");
                __builder2.AddAttribute(30, "class", "col-12");
                __builder2.AddContent(31, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
                              LoginMesssage

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
#line 41 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Login.razor"
       
    private User user;
    public string LoginMesssage { get; set; }
    ClaimsPrincipal claimsPrincipal;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected async override Task OnInitializedAsync()
    {
        user = new User();

        claimsPrincipal = (await authenticationStateTask).User;

        if (claimsPrincipal.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/index");
        }
        {
            user.Email = "selam@gmail.com";
            user.Password = "Yaso0505";
        }

    }

    private async Task<bool> ValidateUser()
    {
        //assume that user is valid
        //call an API

        var returnedUser = await userService.LoginAsync(user);

        if (returnedUser.AccessToken != null)
        {
            await ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsAuthenticated(returnedUser);
            NavigationManager.NavigateTo("/index");
        }
        else
        {
            LoginMesssage = "Invalid username or password";
        }

        return await Task.FromResult(true);
    }
    private void ToSignUp()
    {
        NavigationManager.NavigateTo("/Signup");
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