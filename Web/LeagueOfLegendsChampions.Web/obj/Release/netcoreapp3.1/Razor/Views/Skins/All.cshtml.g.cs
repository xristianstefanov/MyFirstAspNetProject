#pragma checksum "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2ebfc451102e07162bf26ca89ec221f068bd062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skins_All), @"mvc.1.0.view", @"/Views/Skins/All.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\_ViewImports.cshtml"
using LeagueOfLegendsChampions.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\_ViewImports.cshtml"
using LeagueOfLegendsChampions.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2ebfc451102e07162bf26ca89ec221f068bd062", @"/Views/Skins/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e0248e0a4407caccfad7dd88b26afb75dfa01bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Skins_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueOfLegendsChampions.Web.ViewModels.Skins.SkinsForSingleChampViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/allSkins.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a2ebfc451102e07162bf26ca89ec221f068bd0624371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</header>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2ebfc451102e07162bf26ca89ec221f068bd0625499", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
   Write(this.Model.ChampionName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'s Skins:</h1>\r\n    <hr>\r\n    <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 14 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
              int skinsCount = this.Model.Skins.ToList().Count;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
             for (int i = 0; i < skinsCount; i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 19 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 20 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 23 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></li>\r\n");
#nullable restore
#line 24 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ol>\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 28 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
              int counter = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
             foreach (var skin in this.Model.Skins)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                 if (counter == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img class=\"d-block w-100\"");
                BeginWriteAttribute("src", " src=\"", 1180, "\"", 1204, 1);
#nullable restore
#line 34 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
WriteAttributeValue("", 1186, skin.SkinImageUrl, 1186, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h5>");
#nullable restore
#line 36 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                           Write(skin.SkinName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img class=\"d-block w-100\"");
                BeginWriteAttribute("src", " src=\"", 1554, "\"", 1578, 1);
#nullable restore
#line 43 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
WriteAttributeValue("", 1560, skin.SkinImageUrl, 1560, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"carousel-caption d-none d-md-block\">\r\n                            <h5>");
#nullable restore
#line 45 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                           Write(skin.SkinName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\xrist\OneDrive\Desktop\MyFirstAspNetProject\Web\LeagueOfLegendsChampions.Web\Views\Skins\All.cshtml"
                 
                counter++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueOfLegendsChampions.Web.ViewModels.Skins.SkinsForSingleChampViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
