#pragma checksum "C:\Users\anast\source\repos\Web\Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34d2759882765a00271af366597671f3837a389"
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
#line 1 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\anast\source\repos\Web\Web\_Imports.razor"
using Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, "<html><body><section><div class=\"main\" style=\"margin-top: 10px; background-color:#DFF5F0; border-radius:10px;\"><div class=\"container-fluid\"><div id=\"My_carousel\" class=\"carousel slide\" data-ride=\"carousel\"><ol class=\"carousel-indicators\"><li data-target=\"#My_carousel\" data-slide-to=\"0\" class=\"active\"></li>\r\n                        <li data-target=\"#My_carousel\" data-slide-to=\"1\"></li>\r\n                        <li data-target=\"#My_carousel\" data-slide-to=\"2\"></li></ol>\r\n                    <div class=\"container-fluid mx-auto\"><div class=\"carousel-inner\"><div class=\"carousel-item active\"><img class=\"rounded-lg d-block img-fluid w-75\" src=\"img/slide01.jpg\" alt=\"Первый слайд\" style=\"margin:auto; object-fit:fill;\">\r\n                                <div class=\"carousel-caption\" style=\"background-color:#f0f0f0; opacity:0.7; border-radius:10px;\"><h3 style=\"color:black;\">Окунитесь в мир хенд-мейда</h3>\r\n                                    <p style=\"color:black;\">Здесь вы найдете что-то себе по душе</p></div></div>\r\n                            <div class=\"carousel-item\"><img class=\"rounded-lg d-block img-fluid w-75\" src=\"img/slide02.jpg\" alt=\"Второй слайд\" style=\"margin:auto; object-fit:fill;\">\r\n                                <div class=\"carousel-caption\" style=\"background-color:#f0f0f0; opacity:0.7; border-radius:10px;\"><h3 style=\"color:black;\">Найдите уникальные подарки</h3>\r\n                                    <p style=\"color:black;\">Ваши близкие такого еще не видели!</p></div></div>\r\n                            <div class=\"carousel-item\"><img class=\"rounded-lg d-block img-fluid w-75\" src=\"img/slide03.jpg\" alt=\"Третий слайд\" style=\"margin:auto; object-fit:fill;\">\r\n                                <div class=\"carousel-caption\" style=\"background-color:#f0f0f0; opacity:0.7; border-radius:10px;\"><h3 style=\"color:black;\">Объединяем любителей уникальности</h3>\r\n                                    <p style=\"color:black;\">Вместе будем индивидуальны!</p></div></div></div></div>\r\n                    <a class=\"carousel-control-prev\" href=\"#My_carousel\" role=\"button\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n                        <span class=\"sr-only\">Previous</span></a>\r\n                    <a class=\"carousel-control-next\" href=\"#My_carousel\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n                        <span class=\"sr-only\">Next</span></a></div></div>\r\n            \r\n\r\n            <div class=\"container-fluid\" style=\"background-color:whitesmoke;\"><h2 class=\"textillo\" style=\"text-align:center; color:black; margin-top:15px\">Специальные предложения</h2></div>\r\n\r\n            \r\n            <div class=\"card-deck\" style=\"margin-top: 30px;\"><ul class=\"card-deck products clearfix mx-auto\"><li class=\"card product-wrapper\"><div class=\"product-item\"><a href=\"#\"><img src=\"img/magnit.png\" class=\"my-img-fluid\"></a>\r\n                            <div class=\"product-list\"><h3>Магнит на холодильник из дерева</h3>\r\n                                <span class=\"price\">150 ₽</span>\r\n                                <a href=\"#\" class=\"buttonlist\">В корзину</a></div></div></li>\r\n                    <li class=\"card product-wrapper\"><div class=\"product-item\"><img src=\"img/milo.png\" class=\"my-img-fluid\">\r\n                            <div class=\"product-list\"><h3>Натуральное мыло с шелком</h3>\r\n                                <span class=\"price\">300 ₽</span>\r\n                                <a href class=\"buttonlist\">В корзину</a></div></div></li>\r\n                    <li class=\"card product-wrapper\"><div class=\"product-item\"><img src=\"img/brosh.png\" class=\"my-img-fluid\">\r\n                            <div class=\"product-list\"><h3>Брошь \"Совенок\"</h3>\r\n                                <span class=\"price\">550 ₽</span>\r\n                                <a href class=\"buttonlist\">В корзину</a></div></div></li></ul>\r\n                <ul class=\"card-deck products clearfix mx-auto\" style=\"margin-top: 30px;\"><li class=\"card product-wrapper\"><div class=\"product-item\"><img src=\"img/product.jpg\" class=\"my-img-fluid\">\r\n                            <div class=\"product-list\"><h3>Товар</h3>\r\n                                <span class=\"price\">550 ₽</span>\r\n                                <a href class=\"buttonlist\">В корзину</a></div></div></li>\r\n                    <li class=\"card product-wrapper\"><div class=\"product-item\"><img src=\"img/product.jpg\" class=\"my-img-fluid\">\r\n                            <div class=\"product-list\"><h3>Товар</h3>\r\n                                <span class=\"price\">550 ₽</span>\r\n                                <a href class=\"buttonlist\">В корзину</a></div></div></li>\r\n                    <li class=\"card product-wrapper\"><div class=\"product-item\"><img src=\"img/product.jpg\" class=\"my-img-fluid\">\r\n                            <div class=\"product-list\"><h3>Товар</h3>\r\n                                <span class=\"price\">550 ₽</span>\r\n                                <a href class=\"buttonlist\">В корзину</a></div></div></li></ul></div>\r\n            \r\n\r\n            <footer class=\"pt-4 my-md-5 pt-md-5\" style=\"margin-top: 50px; background-color: #f0f0f0;\"><div class=\"row justify-content-between\"><div class=\"col-lg-3 col-md-2\" style=\"margin-left:100px;\"><a class=\"d-inline-flex align-items-center mb-2 link-dark text-decoration-none\" href=\"/\"><img class=\"mb-2\" src=\"img/logo.svg\" alt width=\"150\" height=\"130\"></a>\r\n                        <ul class=\"list-unstyled small text-muted\"><li class=\"d-block mb-3 text-muted\">Твоя команда мастеров</li>\r\n                            <li class=\"d-block mb-3 text-muted\">© 2021</li></ul></div>\r\n\r\n                    <div class=\"col-lg-3 col-md-1\"><h5>Популярные категории</h5>\r\n                        \r\n                        <ul class=\"list-unstyled text-small\"><li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Украшения</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Сувениры и подарки</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Одежда и обувь</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Дом и интерьер</a></li>\r\n                            <li class=\"mb-1 product-category\"><a class=\"link-secondary text-decoration-none\" href=\"#\">Сумки и аксессуары</a></li></ul></div>\r\n                    <div class=\"col-md-4\" style=\"margin-right:100px;\"><h5>Оставайтесь на связи</h5>\r\n                        <div class=\"align-items-center mx-auto\" style=\"padding:10px 10px 10px 10px\"><ul class=\"list-unstyled\"><li><a href=\"https://vk.com/anastasiibush\"><img src=\"img/vk.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center; margin:5px 5px 5px 5px\"></a>\r\n                                    <a href=\"https://anastasia.terr@mail.ru/\"><img src=\"img/Mailru.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center;  margin:5px 5px 5px 5px\"></a>\r\n                                    <a href=\"https://www.instagram.com/anastasiihin/?hl=ru\"><img src=\"img/inst.png\" style=\"width:40px; height:40px; display:inline-block; text-align: center\"></a></li></ul></div></div></div></footer></div></section></body></html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
