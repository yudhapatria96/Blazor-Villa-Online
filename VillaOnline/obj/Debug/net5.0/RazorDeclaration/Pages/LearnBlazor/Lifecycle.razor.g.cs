// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VillaOnline.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using VillaOnline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using VillaOnline.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\_Imports.razor"
using VillaOnline.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\Pages\LearnBlazor\Lifecycle.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycle")]
    public partial class Lifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\yudha\source\repos\VillaOnline\VillaOnline\Pages\LearnBlazor\Lifecycle.razor"
 

    private int currentCount = 0;
    List<string> EventType = new List<string>();
    private int Count { get; set; } = 5;
    private void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInitialized()
    {
        EventType.Add("OnInitializaed is called");
    }

    protected override async Task OnInitializedAsync()
    {
        EventType.Add("OnInitializedAsync is called");
        await Task.Delay(1000);
    }
    protected override void OnParametersSet()
    {
        EventType.Add("OnParameteSet is called");
    }
    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("OnParametersSetAsync is called");
        await Task.Delay(1000);
    }
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            currentCount = 111;
        }
        else
        {
            currentCount = 999;
        }
        EventType.Add("OnAfterRender is called");

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("OnAfterRender is called");
        await Task.Delay(1000);


    }

    protected override bool ShouldRender()
    {
        EventType.Add("ShouldRender is called");
        return true;
    }

    void StartCountdown()
    {
        var timer = new Timer(TimeCallBack, null, 1000, 1000);
    }

    void TimeCallBack(object state)
    {
        if (Count > 0)
        {

            Count--;
            InvokeAsync(StateHasChanged); //digunakan untuk render merubah angka

        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
