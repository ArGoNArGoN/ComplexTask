#pragma checksum "C:\pepos\ComplexTaskAnanas\Web\Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c400e85cccf381d712f0b93411b3e82f6848087"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\pepos\ComplexTaskAnanas\Web\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 2 "C:\pepos\ComplexTaskAnanas\Web\Web\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "C:\pepos\ComplexTaskAnanas\Web\Web\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-06vxonwb36");
            __builder.OpenElement(4, "nav");
            __builder.AddAttribute(5, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddAttribute(6, "style", "margin-top:10px;");
            __builder.AddAttribute(7, "b-06vxonwb36");
            __builder.AddMarkupContent(8, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo01"" aria-controls=""navbarTogglerDemo01"" aria-expanded=""false"" aria-label=""Toggle navigation"" b-06vxonwb36><span class=""navbar-toggler-icon"" b-06vxonwb36></span></button>
        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "collapse navbar-collapse");
            __builder.AddAttribute(11, "id", "navbarTogglerDemo01");
            __builder.AddAttribute(12, "b-06vxonwb36");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "navbar-nav mx-auto mr-auto mt-2 mt-lg-0");
            __builder.AddAttribute(15, "b-06vxonwb36");
            __builder.AddMarkupContent(16, "<li class=\"nav-item active navbar-text\" b-06vxonwb36><a class=\"nav-link\" href=\"/Index\" b-06vxonwb36>Главная<span class=\"sr-only\" b-06vxonwb36>(current)</span></a></li>\r\n                ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item navbar-text");
            __builder.AddAttribute(19, "b-06vxonwb36");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "/Category");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "C:\pepos\ComplexTaskAnanas\Web\Web\Shared\NavMenu.razor"
                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-06vxonwb36></span>Каталог товаров\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<li class=\"nav-item navbar-text\" b-06vxonwb36><a class=\"nav-link\" href=\"/aboutUs\" b-06vxonwb36>О сайте</a></li>\r\n                ");
            __builder.AddMarkupContent(28, "<li class=\"nav-item navbar-text\" b-06vxonwb36><a class=\"nav-link disabled\" href=\"#\" b-06vxonwb36>Добавить товар</a></li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\pepos\ComplexTaskAnanas\Web\Web\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
