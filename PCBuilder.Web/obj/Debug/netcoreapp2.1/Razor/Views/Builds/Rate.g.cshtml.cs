#pragma checksum "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2acdd7f407d12fac7ef4b2db233a9ff6638a1f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Builds_Rate), @"mvc.1.0.view", @"/Views/Builds/Rate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Builds/Rate.cshtml", typeof(AspNetCore.Views_Builds_Rate))]
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
#line 1 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2acdd7f407d12fac7ef4b2db233a9ff6638a1f6f", @"/Views/Builds/Rate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d02edabacccb3fb145a713897f7249996511045", @"/Views/_ViewImports.cshtml")]
    public class Views_Builds_Rate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCBuilder.Common.Models.ViewModels.PCViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Rate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Builds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
  
    ViewData["Title"] = "Rate";

#line default
#line hidden
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
            BeginContext(210, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(271, 17, false);
#line 11 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
    Write(TempData["Error"]);

#line default
#line hidden
            EndContext();
            BeginContext(289, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
}

#line default
#line hidden
            BeginContext(306, 78, true);
            WriteLiteral("\r\n<h2>Rate</h2>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 404, 1);
#line 19 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
WriteAttributeValue("", 390, Model.CaseUrl, 390, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(405, 196, true);
            WriteLiteral(" alt=\"Case image\" class=\"img-responsive\" />\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(602, 45, false);
#line 24 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.BuildName));

#line default
#line hidden
            EndContext();
            BeginContext(647, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(703, 41, false);
#line 27 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.BuildName));

#line default
#line hidden
            EndContext();
            BeginContext(744, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(841, 40, false);
#line 30 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.Case));

#line default
#line hidden
            EndContext();
            BeginContext(881, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(937, 36, false);
#line 33 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.Case));

#line default
#line hidden
            EndContext();
            BeginContext(973, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(1070, 45, false);
#line 36 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.Processor));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1171, 41, false);
#line 39 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.Processor));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(1309, 48, false);
#line 42 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.GraphicsCard));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1413, 44, false);
#line 45 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.GraphicsCard));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(1554, 47, false);
#line 48 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.Motherboard));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1657, 43, false);
#line 51 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.Motherboard));

#line default
#line hidden
            EndContext();
            BeginContext(1700, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(1797, 42, false);
#line 54 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1895, 38, false);
#line 57 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(2030, 56, false);
#line 60 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfMemorySticks));

#line default
#line hidden
            EndContext();
            BeginContext(2086, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2142, 52, false);
#line 63 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.NumberOfMemorySticks));

#line default
#line hidden
            EndContext();
            BeginContext(2194, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(2291, 47, false);
#line 66 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.PowerSupply));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2394, 43, false);
#line 69 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.PowerSupply));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(2534, 49, false);
#line 72 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.HardDiskDrive));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2639, 45, false);
#line 75 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.HardDiskDrive));

#line default
#line hidden
            EndContext();
            BeginContext(2684, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(2781, 51, false);
#line 78 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.SolidStateDrive));

#line default
#line hidden
            EndContext();
            BeginContext(2832, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2888, 47, false);
#line 81 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.SolidStateDrive));

#line default
#line hidden
            EndContext();
            BeginContext(2935, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(3032, 46, false);
#line 84 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3078, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3134, 42, false);
#line 87 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3176, 97, true);
            WriteLiteral("$\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(3274, 48, false);
#line 90 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.SystemRating));

#line default
#line hidden
            EndContext();
            BeginContext(3322, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3378, 44, false);
#line 93 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.SystemRating));

#line default
#line hidden
            EndContext();
            BeginContext(3422, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(3426, 47, false);
#line 93 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
                                                           Write(Html.DisplayFor(model => model.MaxSystemRating));

#line default
#line hidden
            EndContext();
            BeginContext(3473, 96, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt style=\"width:180px; margin-right: 20px;\">\r\n                ");
            EndContext();
            BeginContext(3570, 46, false);
#line 96 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayNameFor(model => model.UserRating));

#line default
#line hidden
            EndContext();
            BeginContext(3616, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3672, 42, false);
#line 99 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
           Write(Html.DisplayFor(model => model.UserRating));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 81, true);
            WriteLiteral(" / 10\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div class=\"col-sm-3\">\r\n");
            EndContext();
#line 104 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
          
                var userId = userManager.GetUserId(this.User);

                var ratingAndUserId = new Dictionary<string, string>
                    {
                        {"Rating", ""},
                        {"UserId", userId.ToString() },
                        {"Builder", Model.Username },
                        {"BuildName", Model.BuildName }

                    };


                

#line default
#line hidden
#line 117 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
                 if (Model.UsersRatedIds.Contains(userId))
                {

#line default
#line hidden
            BeginContext(4285, 59, true);
            WriteLiteral("                <p>You have already rated this build.</p>\r\n");
            EndContext();
#line 120 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
                }
            else
            {

#line default
#line hidden
            BeginContext(4396, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(4412, 467, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0623aad5fd7c4968b60e201a60193114", async() => {
                BeginContext(4474, 195, true);
                WriteLiteral("\r\n                    <label class=\"control-label\">How will you rate this build?</label>\r\n                    <input name=\"Rating\" class=\"form-control\" placeholder=\"1-10\" />\r\n                    ");
                EndContext();
                BeginContext(4669, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c86102ec63734ba3a729b5fd6b754088", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 126 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserRating);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4735, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4757, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cd8f1055a114ae1870b7b72ef4b9930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 127 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues = ratingAndUserId;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4854, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4879, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 129 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
            }

#line default
#line hidden
            BeginContext(4907, 72, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"alert alert-warning\" role=\"alert\">\r\n    ");
            EndContext();
            BeginContext(4980, 29, false);
#line 134 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
Write(Html.Raw(Model.SystemSummary));

#line default
#line hidden
            EndContext();
            BeginContext(5009, 64, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-offset-4\">\r\n");
            EndContext();
#line 142 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
         if (this.User.Identity.Name == Model.Username)
        {

#line default
#line hidden
            BeginContext(5373, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(5385, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6677769d9050449c8e12b4bf470ae9a8", async() => {
                BeginContext(5467, 9, true);
                WriteLiteral("My builds");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5480, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 145 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
        }

#line default
#line hidden
            BeginContext(5493, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(5501, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad7c16f8f19f475bb56fd1713ac16b0d", async() => {
                BeginContext(5581, 10, true);
                WriteLiteral("All builds");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5595, 32, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<hr />\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5645, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 152 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\Rate.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCBuilder.Common.Models.ViewModels.PCViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
