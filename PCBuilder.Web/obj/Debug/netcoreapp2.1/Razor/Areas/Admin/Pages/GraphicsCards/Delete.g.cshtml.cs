#pragma checksum "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb688feffa622a77176fcd7c47f93068f231123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_GraphicsCards_Delete), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/GraphicsCards/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/GraphicsCards/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Pages_GraphicsCards_Delete), @"{id}")]
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
#line 1 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using PCBuilder.Web;

#line default
#line hidden
#line 2 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using PCBuilder.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using PCBuilder.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb688feffa622a77176fcd7c47f93068f231123", @"/Areas/Admin/Pages/GraphicsCards/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f07c7a1d82b34edfc4a865169b036f8a4ef1bd1", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_GraphicsCards_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(124, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>GraphicsCard</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(298, 61, false);
#line 16 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(403, 57, false);
#line 19 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(504, 58, false);
#line 22 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(562, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(606, 54, false);
#line 25 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(660, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(704, 61, false);
#line 28 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.Architecture));

#line default
#line hidden
            EndContext();
            BeginContext(765, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(809, 57, false);
#line 31 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.Architecture));

#line default
#line hidden
            EndContext();
            BeginContext(866, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(910, 55, false);
#line 34 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.Socket));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1009, 51, false);
#line 37 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.Socket));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1104, 58, false);
#line 40 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.Pipelines));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1206, 54, false);
#line 43 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.Pipelines));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1304, 58, false);
#line 46 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.CoreSpeed));

#line default
#line hidden
            EndContext();
            BeginContext(1362, 44, true);
            WriteLiteral(" \r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1407, 54, false);
#line 49 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.CoreSpeed));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 47, true);
            WriteLiteral(" MHz\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1509, 60, false);
#line 52 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.MemorySpeed));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1613, 56, false);
#line 55 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.MemorySpeed));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 47, true);
            WriteLiteral(" MHz\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1717, 59, false);
#line 58 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.MemoryType));

#line default
#line hidden
            EndContext();
            BeginContext(1776, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1820, 55, false);
#line 61 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.MemoryType));

#line default
#line hidden
            EndContext();
            BeginContext(1875, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1919, 61, false);
#line 64 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.MemoryAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1980, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2024, 57, false);
#line 67 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.MemoryAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 46, true);
            WriteLiteral(" GB\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2128, 57, false);
#line 70 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.MaxPower));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2229, 53, false);
#line 73 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.MaxPower));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 45, true);
            WriteLiteral(" W\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2328, 56, false);
#line 76 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.DirectX));

#line default
#line hidden
            EndContext();
            BeginContext(2384, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2428, 52, false);
#line 79 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.DirectX));

#line default
#line hidden
            EndContext();
            BeginContext(2480, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2524, 54, false);
#line 82 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayNameFor(model => Model.GraphicsCard.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2622, 50, false);
#line 85 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
       Write(Html.DisplayFor(model => Model.GraphicsCard.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 74, true);
            WriteLiteral("$\r\n        </dd>\r\n    </dl>\r\n    <div style=\"margin-left:110px\">\r\n        ");
            EndContext();
            BeginContext(2746, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca29aae062bd41c48fd0946bc3c47300", async() => {
                BeginContext(2766, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2780, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "befb22a169024a1a8536c1169706730d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 90 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Areas\Admin\Pages\GraphicsCards\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GraphicsCard.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2829, 89, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n            ");
                EndContext();
                BeginContext(2918, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cceaa61dd2344958e7297c9671cb1e1", async() => {
                    BeginContext(2976, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2992, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3009, 28, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCBuilder.Web.Areas.Admin.Pages.GraphicsCards.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PCBuilder.Web.Areas.Admin.Pages.GraphicsCards.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PCBuilder.Web.Areas.Admin.Pages.GraphicsCards.DeleteModel>)PageContext?.ViewData;
        public PCBuilder.Web.Areas.Admin.Pages.GraphicsCards.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
