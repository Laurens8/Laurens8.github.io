#pragma checksum "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7c61509dde4817ea413b91eb4b50a6468dbb3c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/dobbelen")]
    public partial class Dobbelen : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 5 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
         foreach (var player in players)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-3 mb-3");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card" + " " + (
#nullable restore
#line 8 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
                                   player.IsSix ? "bg-success" : "bg-secondary"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-body");
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
            __builder.AddContent(18, "speler ");
#nullable restore
#line 10 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
__builder.AddContent(19, player.Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 14 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row justify-content-center mt-3");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-6 align-self-center text-center");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "alert alert-info");
            __builder.AddAttribute(34, "id", "result");
            __builder.AddAttribute(35, "role", "alert");
#nullable restore
#line 19 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
__builder.AddContent(36, resultMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row justify-content-center mt-3");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-3 text-center");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
                                                      Play

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "PLAY");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col-3 text-center");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-danger");
            __builder.AddAttribute(57, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
                                                     Reset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "RESET");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row justify-content-center mt-3");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-6 text-center");
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "number");
            __builder.AddAttribute(70, "class", "form-control");
            __builder.AddAttribute(71, "placeholder", "Hoeveel spelers denk je dat er een 6 gaan gooien? (1-12)");
            __builder.AddAttribute(72, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\laure\OneDrive\Desktop\BlazorApp\BlazorApp\Pages\Dobbelen.razor"
                                        antwoord

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(73, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => antwoord = __value, antwoord, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
