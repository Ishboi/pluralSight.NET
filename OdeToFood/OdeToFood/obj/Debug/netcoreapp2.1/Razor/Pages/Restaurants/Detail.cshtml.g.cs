#pragma checksum "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b8b75293b2316c699a8f981f00b2ce52295991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Detail), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Detail.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Detail), @"{restaurantId:int}")]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantId:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b8b75293b2316c699a8f981f00b2ce52295991", @"/Pages/Restaurants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fe10e6c90f307728f15587f1d83247c98c9355", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(120, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(127, 21, false);
#line 8 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
Write(Model.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(148, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 9 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
 if(Model.Message != null)
{

#line default
#line hidden
            BeginContext(186, 32, true);
            WriteLiteral("  <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(219, 13, false);
#line 11 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
                           Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(232, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 12 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(243, 15, true);
            WriteLiteral("<div>\r\n    Id: ");
            EndContext();
            BeginContext(259, 19, false);
#line 14 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
   Write(Model.Restaurant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(278, 31, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(310, 25, false);
#line 17 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
         Write(Model.Restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(335, 30, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Cuisine: ");
            EndContext();
            BeginContext(366, 24, false);
#line 20 "D:\.NET\pluralsight\OdeToFood\OdeToFood\Pages\Restaurants\Detail.cshtml"
        Write(Model.Restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(390, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(404, 64, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "761fd4efdc424557bf343528a3846a00", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb6b649a8723408eaf7c339908bd71d6", async() => {
>>>>>>> f657de0a99c361615833d858f42afe185ab6b987
                BeginContext(449, 15, true);
                WriteLiteral("All Restaurants");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
