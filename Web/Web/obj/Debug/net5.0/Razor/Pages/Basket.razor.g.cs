#pragma checksum "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d5553779c6015277fadd0c3c8d549420cc9a52"
// <auto-generated/>
#pragma warning disable 1591
namespace Web.Pages
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
#nullable restore
#line 2 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
using Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
using Web.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Basket")]
    public partial class Basket : Web.Pages.BasketLoad
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddAttribute(3, "style", "margin-top: 10px; background-color:#DFF5F0; border-radius:10px;");
            __builder.AddMarkupContent(4, "<div class=\"container-fluid\" style=\"background-color:whitesmoke;\"><h3 style=\"text-align:center; color:black; margin:15px 0px 15px 0px\">Корзина</h3>\r\n            <hr></div>\r\n\r\n        \r\n\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
#nullable restore
#line 31 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
             foreach (var item in Baskets)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-3 col-sm-3 col-xs-12");
            __builder.AddAttribute(9, "style", "height: 100px; line-height: 100px; text-align:center;");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 34 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
                               item.IdProductNavigation.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "style", "width: 80px; height: 80px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-3 col-sm-3 col-xs-12 mob-fix");
            __builder.AddAttribute(16, "style", "height: 100px; line-height: 100px;");
            __builder.AddContent(17, 
#nullable restore
#line 37 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
                     item.IdProductNavigation.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-lg-2 col-sm-2 col-xs-12 mob-fix");
            __builder.AddAttribute(21, "style", "height: 100px; line-height: 100px;");
            __builder.AddContent(22, 
#nullable restore
#line 40 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
                      $"{item.Price} ₽"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-lg-1 col-sm-2 col-xs-12 mob-fix");
            __builder.AddAttribute(26, "style", "height: 100px; line-height: 100px;");
            __builder.AddContent(27, 
#nullable restore
#line 43 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
                     item.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-lg-3 col-sm-2 col-xs-12 mob-fix");
            __builder.AddAttribute(31, "style", "height: 100px; line-height: 100px;");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
                                                                                                                      (() => delete(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                    Удалить\r\n                ");
            __builder.CloseElement();
#nullable restore
#line 48 "C:\pepos\ComplexTaskAnanas\Web\Web\Pages\Basket.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(35, "<div style=\"width: 100%; text-align: right;\"><div style=\"width: 70%; float: right;\"><a href=\"#\" class=\"buttonlist\" style=\"text-transform:none; background-color:#fc5a5a;\">Оформить заказ</a></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n<footer class=\"pt-4 my-md-5 pt-md-5\" style=\"margin-top: 150px; background-color: #f0f0f0;\"></footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
