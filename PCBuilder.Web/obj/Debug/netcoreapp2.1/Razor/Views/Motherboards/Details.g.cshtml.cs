#pragma checksum "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c390caebb6ea4393f7f193df375112ed13c9749"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Motherboards_Details), @"mvc.1.0.view", @"/Views/Motherboards/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Motherboards/Details.cshtml", typeof(AspNetCore.Views_Motherboards_Details))]
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
#line 1 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\_ViewImports.cshtml"
using PCBuilder.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\_ViewImports.cshtml"
using PCBuilder.Models;

#line default
#line hidden
#line 3 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\_ViewImports.cshtml"
using PCBuilder.Common;

#line default
#line hidden
#line 4 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\_ViewImports.cshtml"
using PCBuilder.Common.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c390caebb6ea4393f7f193df375112ed13c9749", @"/Views/Motherboards/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d02edabacccb3fb145a713897f7249996511045", @"/Views/_ViewImports.cshtml")]
    public class Views_Motherboards_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCBuilder.Common.Models.ViewModels.MotherboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Motherboards", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(109, 166, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Motherboard</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(276, 48, false);
#line 14 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(324, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(368, 44, false);
#line 17 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(412, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(497, 45, false);
#line 20 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(586, 41, false);
#line 23 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(627, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(712, 57, false);
#line 26 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcessorSocketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 53, false);
#line 29 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProcessorSocketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(866, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(951, 60, false);
#line 32 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GraphicsCardSocketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1055, 56, false);
#line 35 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.GraphicsCardSocketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(1196, 43, false);
#line 38 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Chipset));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1283, 39, false);
#line 41 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.Chipset));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(1407, 46, false);
#line 44 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MemoryType));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1497, 42, false);
#line 47 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.MemoryType));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(1624, 54, false);
#line 50 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MemorySocketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1722, 50, false);
#line 53 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.MemorySocketNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(1857, 45, false);
#line 56 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxMemory));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1946, 41, false);
#line 59 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxMemory));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 87, true);
            WriteLiteral(" GB\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(2075, 55, false);
#line 62 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfMemorySlots));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2174, 51, false);
#line 65 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfMemorySlots));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(2310, 50, false);
#line 68 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PowerConnector));

#line default
#line hidden
            EndContext();
            BeginContext(2360, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2404, 46, false);
#line 71 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.PowerConnector));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(2535, 48, false);
#line 74 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HDDInterface));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2627, 44, false);
#line 77 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.HDDInterface));

#line default
#line hidden
            EndContext();
            BeginContext(2671, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(2756, 48, false);
#line 80 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SSDInterface));

#line default
#line hidden
            EndContext();
            BeginContext(2804, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2848, 44, false);
#line 83 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.SSDInterface));

#line default
#line hidden
            EndContext();
            BeginContext(2892, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(2977, 46, false);
#line 86 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FormFactor));

#line default
#line hidden
            EndContext();
            BeginContext(3023, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3067, 42, false);
#line 89 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.FormFactor));

#line default
#line hidden
            EndContext();
            BeginContext(3109, 84, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt style=\"width:200px; margin-right: 20px;\">\r\n            ");
            EndContext();
            BeginContext(3194, 41, false);
#line 92 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3235, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3279, 37, false);
#line 95 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3316, 70, true);
            WriteLiteral("$\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div style=\"margin-left:150px\">\r\n");
            EndContext();
#line 100 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
     if (this.User.IsInRole(WebConstants.AdminRole))
    {

#line default
#line hidden
            BeginContext(3447, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(3455, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab9128768f04c61a834127befc998fd", async() => {
                BeginContext(3574, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3582, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 103 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Motherboards\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(3591, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(3595, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a4c00d2ad7342aa969990fb6abd8127", async() => {
                BeginContext(3683, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3699, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCBuilder.Common.Models.ViewModels.MotherboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
