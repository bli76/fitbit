#pragma checksum "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0bb6ce9656fb27dddd2b8470203aa81ab1832db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0bb6ce9656fb27dddd2b8470203aa81ab1832db", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NorthwindMvc.Models.HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductsThatCostMoreThan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home Page";
  string currentItem = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"categories\" class=\"carousel slide\" data-ride=\"carousel\" \r\n     data-interval=\"3000\" data-keyboard=\"true\">\r\n  <ol class=\"carousel-indicators\">\r\n");
#nullable restore
#line 9 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
   for (int c = 0; c < Model.Categories.Count; c++)
  {
    if (c == 0)
    {
      currentItem = "active";
    }
    else
    {
      currentItem = "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li data-target=\"#categories\" data-slide-to=\"");
#nullable restore
#line 19 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
                                            Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " \r\n      class=\"", 491, "\"", 519, 1);
#nullable restore
#line 20 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 507, currentItem, 507, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 21 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ol>\r\n  <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 24 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
   for (int c = 0; c < Model.Categories.Count; c++)
  {
    if (c == 0)
    {
      currentItem = "active";
    }
    else
    {
      currentItem = "";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 751, "\"", 785, 2);
            WriteAttributeValue("", 759, "carousel-item", 759, 13, true);
#nullable restore
#line 34 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 772, currentItem, 773, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0bb6ce9656fb27dddd2b8470203aa81ab1832db8010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 829, "~/images/category", 829, 17, true);
#nullable restore
#line 36 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 846, Model.Categories[c].CategoryID, 846, 33, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 879, ".jpeg", 879, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 901, Model.Categories[c].CategoryName, 901, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      <div class=\"carousel-caption d-none d-md-block\">\r\n        <h2>");
#nullable restore
#line 39 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
       Write(Model.Categories[c].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 40 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
       Write(Model.Categories[c].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>\r\n          <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " \r\nhref=\"", 1148, "\"", 1198, 2);
            WriteAttributeValue("", 1157, "/category/", 1157, 10, true);
#nullable restore
#line 43 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 1167, Model.Categories[c].CategoryID, 1167, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n        </p>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>
  <a class=""carousel-control-prev"" href=""#categories"" 
    role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" 
      aria-hidden=""true""></span>
    <span class=""sr-only"">Previous</span>
  </a>
  <a class=""carousel-control-next"" href=""#categories"" 
    role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" 
      aria-hidden=""true""></span>
    <span class=""sr-only"">Next</span>
  </a>
</div>
<div class=""row"">
  <div class=""col-md-12"">
    <h1>Northwind</h1>
    <p class=""lead"">
      We have had ");
#nullable restore
#line 66 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
             Write(Model.VisitorCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" visitors this month.\r\n    </p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0bb6ce9656fb27dddd2b8470203aa81ab1832db12443", async() => {
                WriteLiteral("\r\n      <input name=\"price\" placeholder=\"Enter a product price\" />\r\n      <input type=\"submit\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0bb6ce9656fb27dddd2b8470203aa81ab1832db14190", async() => {
                WriteLiteral("\r\n      <input name=\"country\" placeholder=\"Enter a country\" />\r\n      <input type=\"submit\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h2>Products</h2>\r\n      <div id=\"newspaper\">\r\n        <ul>\r\n");
#nullable restore
#line 79 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
         foreach (var item in @Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0bb6ce9656fb27dddd2b8470203aa81ab1832db16292", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 85 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
       Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" costs\r\n            ");
#nullable restore
#line 86 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
       Write(item.UnitPrice.Value.ToString("C"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
                 WriteLiteral(item.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 89 "C:\Users\Zoey\Downloads\PracticalApps\PracticalApps\NorthwindMvc\Views\Home\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </ul>\r\n    </div>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindMvc.Models.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591