#pragma checksum "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02929a2d8c71322a8cfa2fbbb7620013e2f84b1c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_TKP_APP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Blazor_TKP_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/_Imports.razor"
using Blazor_TKP_APP.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "/Users/hyuga/Projects/Blazor_TKP_APP/Blazor_TKP_APP/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
