// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Index.razor"
using Blazzor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Index.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\UnluCo.Bitirme.WEBAPI\UnluCo.Bitirme.Blazzor\Pages\Index.razor"
        [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    ClaimsPrincipal user;

    bool IsUserAuthenticated;

    protected override async Task OnInitializedAsync()
    {
        user = (await authenticationStateTask).User;

        if (user.Identity.IsAuthenticated)
            IsUserAuthenticated = true;

        
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
