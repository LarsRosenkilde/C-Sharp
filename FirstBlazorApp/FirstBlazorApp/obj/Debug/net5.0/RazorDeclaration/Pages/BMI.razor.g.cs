// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FirstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using FirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using FirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bmi")]
    public partial class BMI : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Lars Rosenkilde\Desktop\Code\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\BMI.razor"
       
    private int height { get; set; }
    private int weight { get; set; }
    private double bmi;

    private void Calculate()
    {
        bmi = Math.Round((weight / Math.Pow(height, 2)) * 10000, 2);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
