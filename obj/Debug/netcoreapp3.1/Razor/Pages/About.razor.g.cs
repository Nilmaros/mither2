#pragma checksum "/Users/nilmaros/dev/mither2/Pages/About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb7e7722773e13086069f7c7d26acfe25a924f4"
// <auto-generated/>
#pragma warning disable 1591
namespace mither2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nilmaros/dev/mither2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nilmaros/dev/mither2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nilmaros/dev/mither2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nilmaros/dev/mither2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nilmaros/dev/mither2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nilmaros/dev/mither2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nilmaros/dev/mither2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nilmaros/dev/mither2/_Imports.razor"
using mither2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nilmaros/dev/mither2/_Imports.razor"
using mither2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "/Users/nilmaros/dev/mither2/Pages/About.razor"
 if (Banner)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenComponent<mither2.Shared.Banner>(1);
            __builder.AddAttribute(2, "Page", "About");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 6 "/Users/nilmaros/dev/mither2/Pages/About.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "\n\n");
            __builder.AddMarkupContent(5, @"<section class=""about_area section_gap"">
    <div class=""container"">
        <div class=""row justify-content-start align-items-center"">
            <div class=""col-lg-5"">
                <div class=""about_img"">
                    <img class src=""img/about-us.png"" alt>
                </div>
            </div>

            <div class=""offset-lg-1 col-lg-5"">
                <div class=""main_title text-left"">
                    <h2>let’s <br>
                        Introduce about <br>
                        myself</h2>
                    <p>
                        Whose given. Were gathered. There first subdue greater. Bearing you Whales heaven 
                        midst their. Beast creepeth. Fish days.
                    </p>
                    <p>
                        Is give may shall likeness made yielding spirit a itself together created after sea 
                        is in beast beginning signs open god you're gathering whose gathered cattle let. 
                        Creature whales fruit unto meat the life beginning all in under give two.
                    </p>
                    <a class=""primary_btn"" href=""#""><span>Download CV</span></a>
                </div>
            </div>
        </div>
    </div>
</section>");
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/nilmaros/dev/mither2/Pages/About.razor"
      
    [Parameter]
    public bool Banner { get; set; } = true;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
