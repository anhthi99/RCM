#pragma checksum "D:\Projects\NETCore\Blazor\RCM\RCM\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e792983465b487f10c902d0078defd009481241"
// <auto-generated/>
#pragma warning disable 1591
namespace RCM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using RCM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\NETCore\Blazor\RCM\RCM\_Imports.razor"
using RCM.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 2 "D:\Projects\NETCore\Blazor\RCM\RCM\Shared\LoginDisplay.razor"
            context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "!\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
