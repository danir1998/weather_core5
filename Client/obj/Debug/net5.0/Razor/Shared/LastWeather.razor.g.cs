#pragma checksum "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14946f31d4313d59425ac4402a3326d94fdf925d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using BlazorClient.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\danir\Desktop\FW\Client\_Imports.razor"
using BlazorClient.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
    public partial class LastWeather : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Last Weather</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "last-weather");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "align-items-center");
            __builder.OpenElement(7, "h1");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
                 data.tp

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, " °С");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.OpenElement(12, "h3");
            __builder.AddMarkupContent(13, " Город: ");
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
                         data.state

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "h3");
            __builder.AddMarkupContent(17, " Давление: ");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
                            data.pr

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, " мм рт. ст");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "h3");
            __builder.AddMarkupContent(22, " Влажность: ");
            __builder.AddContent(23, 
#nullable restore
#line 12 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
                             data.hu

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(24, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "h3");
            __builder.AddMarkupContent(27, " Ветер: ");
            __builder.AddContent(28, 
#nullable restore
#line 13 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
                         data.wd

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, " м/с");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\danir\Desktop\FW\Client\Shared\LastWeather.razor"
       
    [Parameter]
    public Weather data { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591