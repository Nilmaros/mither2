#pragma checksum "C:\repos\mither2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c56e7c85b0052446c09486258f5ddf4699e95bb"
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
#line 1 "C:\repos\mither2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\repos\mither2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\repos\mither2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\repos\mither2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\repos\mither2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\repos\mither2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\repos\mither2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\repos\mither2\_Imports.razor"
using mither2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\repos\mither2\_Imports.razor"
using mither2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!doctype html>\r\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "en");
            __builder.AddMarkupContent(3, "\r\n    \r\n");
            __builder.OpenElement(4, "body");
            __builder.AddMarkupContent(5, "\r\n\r\n\t\r\n    ");
            __builder.OpenComponent<mither2.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n\t\r\n\r\n\t\r\n\t");
            __builder.AddMarkupContent(8, @"<section class=""home_banner_area"">
		<div class=""banner_inner"">
			<div class=""container"">
				<div class=""row"">
					<div class=""col-lg-7"">
						<div class=""banner_content"">
							<h3 class=""text-uppercase"">Hell0</h3>
							<h1 class=""text-uppercase"">I am Mitchell Hernandez</h1>
							<h5 class=""text-uppercase"">Azure Cloud Developer</h5>
							<div class=""d-flex align-items-center"">
								<a class=""primary_btn"" href=""#""><span>Hire Me</span></a>
								<a class=""primary_btn tr-bg"" href=""#""><span>Get CV</span></a>
							</div>
						</div>
					</div>
					<div class=""col-lg-5"">
						<div class=""home_right_img"">
							<img class src=""img/banner/home-right.png"" alt>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	

	
	");
            __builder.OpenComponent<mither2.Pages.About>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\t\r\n\r\n\t\r\n\t");
            __builder.AddMarkupContent(11, "<section class=\"brand_area section_gap_bottom\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row justify-content-center\">\r\n\t\t\t\t<div class=\"col-lg-6\">\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo1.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo2.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo3.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo4.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo5.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo6.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo7.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo8.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"single-brand-item d-table\">\r\n\t\t\t\t\t\t\t\t<div class=\"d-table-cell text-center\">\r\n\t\t\t\t\t\t\t\t\t<img src=\"img/brands/logo9.png\" alt>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"offset-lg-2 col-lg-4 col-md-6\">\r\n\t\t\t\t\t<div class=\"client-info\">\r\n\t\t\t\t\t\t<div class=\"d-flex mb-50\">\r\n\t\t\t\t\t\t\t<span class=\"lage\">10</span>\r\n\t\t\t\t\t\t\t<span class=\"smll\">Years Experience Working</span>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"call-now d-flex\">\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t<span class=\"fa fa-phone\"></span>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"ml-15\">\r\n\t\t\t\t\t\t\t\t<p>call us now</p>\r\n\t\t\t\t\t\t\t\t<h3>(+1)-800-555-6789</h3>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\t\r\n\r\n\t\r\n\t");
            __builder.AddMarkupContent(12, "<section class=\"features_area\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row justify-content-center\">\r\n\t\t\t\t<div class=\"col-lg-8 text-center\">\r\n\t\t\t\t\t<div class=\"main_title\">\r\n\t\t\t\t\t\t<h2>service offers </h2>\r\n\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\tIs give may shall likeness made yielding spirit a itself togeth created \r\n\t\t\t\t\t\t\tafter sea <br> is in beast beginning signs open god you\'re gathering ithe\r\n\t\t\t\t\t\t</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"row feature_inner\">\r\n\t\t\t\t<div class=\"col-lg-3 col-md-6\">\r\n\t\t\t\t\t<div class=\"feature_item\">\r\n\t\t\t\t\t\t<img src=\"img/services/s1.png\" alt>\r\n\t\t\t\t\t\t<h4>Wp developing</h4>\r\n\t\t\t\t\t\t<p>Creeping for female light years that lesser can\'t evening heaven isn\'t bearing tree</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-lg-3 col-md-6\">\r\n\t\t\t\t\t<div class=\"feature_item\">\r\n\t\t\t\t\t\t<img src=\"img/services/s2.png\" alt>\r\n\t\t\t\t\t\t<h4>UI/ux design</h4>\r\n\t\t\t\t\t\t<p>Creeping for female light years that lesser can\'t evening heaven isn\'t bearing tree</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-lg-3 col-md-6\">\r\n\t\t\t\t\t<div class=\"feature_item\">\r\n\t\t\t\t\t\t<img src=\"img/services/s3.png\" alt>\r\n\t\t\t\t\t\t<h4>Web design</h4>\r\n\t\t\t\t\t\t<p>Creeping for female light years that lesser can\'t evening heaven isn\'t bearing tree</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-lg-3 col-md-6\">\r\n\t\t\t\t\t<div class=\"feature_item\">\r\n\t\t\t\t\t\t<img src=\"img/services/s4.png\" alt>\r\n\t\t\t\t\t\t<h4>seo optimize</h4>\r\n\t\t\t\t\t\t<p>Creeping for female light years that lesser can\'t evening heaven isn\'t bearing tree</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\t\r\n\r\n\t\r\n\t");
            __builder.AddMarkupContent(13, "<section class=\"portfolio_area\" id=\"portfolio\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-lg-12\">\r\n\t\t\t\t\t<div class=\"main_title text-left\">\r\n\t\t\t\t\t\t<h2>quality work <br>\r\n\t\t\t\t\t\t\tRecently done project </h2>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"filters portfolio-filter\">\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li class=\"active\" data-filter=\"*\">all</li>\r\n\t\t\t\t\t<li data-filter=\".popular\">popular</li>\r\n\t\t\t\t\t<li data-filter=\".latest\"> latest</li>\r\n\t\t\t\t\t<li data-filter=\".following\">following</li>\r\n\t\t\t\t\t<li data-filter=\".upcoming\">upcoming</li>\r\n\t\t\t\t</ul>\r\n\t\t\t</div>\r\n\t\r\n\t\t\t<div class=\"filters-content\">\r\n\t\t\t\t<div class=\"row portfolio-grid justify-content-center\">\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all latest\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p1.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p1.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">minimal design</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all popular\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p2.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p2.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">Paint wall</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all latest\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p3.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p3.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">female light</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all popular\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p4.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p4.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">fourth air</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all following\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p6.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p5.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">together sign</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all upcoming\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p5.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p6.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">multiply fowl</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all upcoming following\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p7.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p7.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">green heaven</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all following\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p8.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p8.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4>fly male</h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-6 all upcoming\">\r\n\t\t\t\t\t\t<div class=\"portfolio_box\">\r\n\t\t\t\t\t\t\t<div class=\"single_portfolio\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid w-100\" src=\"img/portfolio/p9.jpg\" alt>\r\n\t\t\t\t\t\t\t\t<div class=\"overlay\"></div>\r\n\t\t\t\t\t\t\t\t<a href=\"img/portfolio/p9.jpg\" class=\"img-gal\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"icon\">\r\n\t\t\t\t\t\t\t\t\t\t<span class=\"lnr lnr-cross\"></span>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"short_info\">\r\n\t\t\t\t\t\t\t\t<h4><a href=\"portfolio-details.html\">season face</a></h4>\r\n\t\t\t\t\t\t\t\t<p>Animated, portfolio</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</section>\r\n\t\r\n\r\n\t\r\n\t");
            __builder.AddMarkupContent(14, "<div class=\"testimonial_area section_gap_bottom\">\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row justify-content-center\">\r\n\t\t\t\t<div class=\"col-lg-8 text-center\">\r\n\t\t\t\t\t<div class=\"main_title\">\r\n\t\t\t\t\t\t<h2>client say about me</h2>\r\n\t\t\t\t\t\t<p>Is give may shall likeness made yielding spirit a itself togeth created after sea is in beast <br>\r\n\t\t\t\t\t\t\t beginning signs open god you\'re gathering ithe</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"testi_slider owl-carousel\">\r\n        \t\t\t<div class=\"testi_item\">\r\n        \t\t\t\t<div class=\"row\">\r\n        \t\t\t\t\t<div class=\"col-lg-4\">\r\n        \t\t\t\t\t\t<img src=\"img/testimonials/t1.jpg\" alt>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t\t<div class=\"col-lg-8\">\r\n        \t\t\t\t\t\t<div class=\"testi_text\">\r\n        \t\t\t\t\t\t\t<h4>Elite Martin</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Him, made can\'t called over won\'t there on divide there male fish beast own his day third seed sixth seas unto. Saw from </p>\r\n        \t\t\t\t\t\t</div>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t</div>\r\n        \t\t\t</div>\r\n        \t\t\t<div class=\"testi_item\">\r\n        \t\t\t\t<div class=\"row\">\r\n        \t\t\t\t\t<div class=\"col-lg-4\">\r\n        \t\t\t\t\t\t<img src=\"img/testimonials/t2.jpg\" alt>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t\t<div class=\"col-lg-8\">\r\n        \t\t\t\t\t\t<div class=\"testi_text\">\r\n        \t\t\t\t\t\t\t<h4>Davil Saden</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Him, made can\'t called over won\'t there on divide there male fish beast own his day third seed sixth seas unto. Saw from </p>\r\n        \t\t\t\t\t\t</div>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t</div>\r\n        \t\t\t</div>\r\n        \t\t\t<div class=\"testi_item\">\r\n        \t\t\t\t<div class=\"row\">\r\n        \t\t\t\t\t<div class=\"col-lg-4\">\r\n        \t\t\t\t\t\t<img src=\"img/testimonials/t1.jpg\" alt>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t\t<div class=\"col-lg-8\">\r\n        \t\t\t\t\t\t<div class=\"testi_text\">\r\n        \t\t\t\t\t\t\t<h4>Elite Martin</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Him, made can\'t called over won\'t there on divide there male fish beast own his day third seed sixth seas unto. Saw from </p>\r\n        \t\t\t\t\t\t</div>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t</div>\r\n        \t\t\t</div>\r\n        \t\t\t<div class=\"testi_item\">\r\n        \t\t\t\t<div class=\"row\">\r\n        \t\t\t\t\t<div class=\"col-lg-4\">\r\n        \t\t\t\t\t\t<img src=\"img/testimonials/t2.jpg\" alt>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t\t<div class=\"col-lg-8\">\r\n        \t\t\t\t\t\t<div class=\"testi_text\">\r\n        \t\t\t\t\t\t\t<h4>Davil Saden</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Him, made can\'t called over won\'t there on divide there male fish beast own his day third seed sixth seas unto. Saw from </p>\r\n        \t\t\t\t\t\t</div>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t</div>\r\n        \t\t\t</div>\r\n        \t\t\t<div class=\"testi_item\">\r\n        \t\t\t\t<div class=\"row\">\r\n        \t\t\t\t\t<div class=\"col-lg-4\">\r\n        \t\t\t\t\t\t<img src=\"img/testimonials/t1.jpg\" alt>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t\t<div class=\"col-lg-8\">\r\n        \t\t\t\t\t\t<div class=\"testi_text\">\r\n        \t\t\t\t\t\t\t<h4>Elite Martin</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Him, made can\'t called over won\'t there on divide there male fish beast own his day third seed sixth seas unto. Saw from </p>\r\n        \t\t\t\t\t\t</div>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t</div>\r\n        \t\t\t</div>\r\n        \t\t\t<div class=\"testi_item\">\r\n        \t\t\t\t<div class=\"row\">\r\n        \t\t\t\t\t<div class=\"col-lg-4\">\r\n        \t\t\t\t\t\t<img src=\"img/testimonials/t2.jpg\" alt>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t\t<div class=\"col-lg-8\">\r\n        \t\t\t\t\t\t<div class=\"testi_text\">\r\n        \t\t\t\t\t\t\t<h4>Davil Saden</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Him, made can\'t called over won\'t there on divide there male fish beast own his day third seed sixth seas unto. Saw from </p>\r\n        \t\t\t\t\t\t</div>\r\n        \t\t\t\t\t</div>\r\n        \t\t\t\t</div>\r\n        \t\t\t</div>\r\n        \t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t\r\n\r\n\t\r\n\t");
            __builder.AddMarkupContent(15, @"<section class=""newsletter_area"">
		<div class=""container"">
			<div class=""row justify-content-center align-items-center"">
				<div class=""col-lg-12"">
					<div class=""subscription_box text-center"">
						<h2 class=""text-uppercase text-white"">get update from anywhere</h2>
						<p class=""text-white"">
							Bearing Void gathering light light his eavening unto dont afraid. 
						</p>
						<div class=""subcribe-form"" id=""mc_embed_signup"">
							<form target=""_blank"" novalidate=""true"" action=""https://spondonit.us12.list-manage.com/subscribe/post?u=1462626880ade1ac87bd9c93a&amp;id=92a4423d01"" method=""get"" class=""subscription relative"">
								<input name=""EMAIL"" placeholder=""Email address"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Email address'"" required type=""email"">
								<div style=""position: absolute; left: -5000px;"">
									<input name=""b_36c4fd991d266f23781ded980_aefe40901a"" tabindex=""-1"" value type=""text"">
								</div>
								<button class=""primary-btn hover d-inline"">Get Started</button>
								<div class=""info""></div>
							</form>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	

	
	");
            __builder.AddMarkupContent(16, @"<footer class=""footer_area"">
		<div class=""container"">
			<div class=""row justify-content-center"">
				<div class=""col-lg-12"">
					<div class=""footer_top flex-column"">
						<div class=""footer_logo"">
							<a href=""#"">
								<img src=""img/logo.png"" alt>
							</a>
							<h4>Follow Me</h4>
						</div>
						<div class=""footer_social"">
							<a href=""#""><i class=""fa fa-facebook""></i></a>
							<a href=""#""><i class=""fa fa-twitter""></i></a>
							<a href=""#""><i class=""fa fa-dribbble""></i></a>
							<a href=""#""><i class=""fa fa-behance""></i></a>
						</div>
					</div>
				</div>
			</div>
			<div class=""row footer_bottom justify-content-center"">
				<p class=""col-lg-8 col-sm-12 footer-text"">
					
</p>
			</div>
		</div>
	</footer>
	

	
	
");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
