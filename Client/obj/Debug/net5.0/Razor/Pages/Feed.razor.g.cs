#pragma checksum "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5706b18200a79e674c196d0c0a258eb9d724f8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Client.Pages
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
#line 4 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Feed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "form");
            __builder.AddAttribute(4, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 9 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                     sendForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "row g-3 mb-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-4");
            __builder.AddMarkupContent(8, "<label for=\"date1\" class=\"visually-hidden\">Start date</label>\r\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "type", "date");
            __builder.AddAttribute(12, "name", "date1");
            __builder.AddAttribute(13, "id", "date1");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                          date1

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date1 = __value, date1, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-4");
            __builder.AddMarkupContent(19, "<label for=\"date2\" class=\"visually-hidden\">End date</label>\r\n            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "class", "form-control");
            __builder.AddAttribute(22, "type", "date");
            __builder.AddAttribute(23, "name", "date2");
            __builder.AddAttribute(24, "id", "date2");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                          date2

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date2 = __value, date2, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.AddMarkupContent(28, "<div class=\"col-4\"><button type=\"submit\" id=\"btn\" class=\"btn btn-primary\">Reload data</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
 if (weathers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "<p><em>Loading...</em></p>");
#nullable restore
#line 27 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorClient.Client.Shared.LastWeather>(30);
            __builder.AddAttribute(31, "data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorClient.Shared.Weather>(
#nullable restore
#line 30 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                       last

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table");
            __builder.AddMarkupContent(34, "<thead><tr><th>#</th>\r\n                <th>State</th>\r\n                <th>City</th>\r\n                <th>Date</th>\r\n                <th>Temp °С</th>\r\n                <th>Pressure (mm. ps.)</th></tr></thead>\r\n        ");
            __builder.OpenElement(35, "tbody");
#nullable restore
#line 45 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
             foreach (var info in weathers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 48 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                         info.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 49 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                         info.state

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 50 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                         info.city

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 51 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                         info.timestamp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 52 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                         info.tp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 53 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
                         info.pr

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "<div class=\"container-fluid\"><canvas id=\"myChart\" width=\"300\" height=\"100\"></canvas></div>");
#nullable restore
#line 62 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\danir\Desktop\FW\Client\Pages\Feed.razor"
       
    private Weather[] weathers;
    private Weather last;

    private DateTime date1 = DateTime.Now;
    private DateTime date2 = DateTime.Now;

    protected override async Task OnInitializedAsync()
    {
        weathers = await Http.GetFromJsonAsync<Weather[]>("api/weather");
        last = await Http.GetFromJsonAsync<Weather>("api/weather/last");
    }

    private async Task sendForm()
    {
        string url = string.Format("api/weather/date/{0}/{1}", date1, date2);
        weathers = await Http.GetFromJsonAsync<Weather[]>(url);

        int[] data = weathers.Select(x => x.tp).ToArray();
        string[] label = weathers.Select(x => x.timestamp.Value.ToShortDateString()).ToArray();

        js.InvokeVoidAsync("renderChart", data, label);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
