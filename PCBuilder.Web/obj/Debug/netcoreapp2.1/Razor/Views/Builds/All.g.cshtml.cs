#pragma checksum "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e64ddaf392fe30d4dbc4cbaa8a1358c1879ed6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Builds_All), @"mvc.1.0.view", @"/Views/Builds/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Builds/All.cshtml", typeof(AspNetCore.Views_Builds_All))]
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
#line 2 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e64ddaf392fe30d4dbc4cbaa8a1358c1879ed6c", @"/Views/Builds/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d02edabacccb3fb145a713897f7249996511045", @"/Views/_ViewImports.cshtml")]
    public class Views_Builds_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PCBuilder.Common.Models.ViewModels.PCViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Builds", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
#line 8 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
            BeginContext(263, 59, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(324, 17, false);
#line 11 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
    Write(TempData["Error"]);

#line default
#line hidden
            EndContext();
            BeginContext(342, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
}

#line default
#line hidden
            BeginContext(359, 34, true);
            WriteLiteral("\r\n<h2>All builds</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(393, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48cf825833fd4f058eb8971a7a672b2b", async() => {
                BeginContext(440, 10, true);
                WriteLiteral("Build a PC");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(454, 322, true);
            WriteLiteral(@"
</p>
<table class=""table table-responsive"">
    <thead>
        <tr>
            <th>
                <span style=""margin-left:100px"">PC image</span>
            </th>
            <th>
                <span style=""margin-left:170px"">Details</span>
            </th>

        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 33 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(825, 64, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 889, "\"", 908, 1);
#line 37 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
WriteAttributeValue("", 895, item.CaseUrl, 895, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(909, 241, true);
            WriteLiteral(" alt=\"PC image\" class=\"\" style=\"width:250px\" />\r\n                </td>\r\n                <td>\r\n                    <dl class=\"dl-horizontal\">\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(1151, 43, false);
#line 42 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1286, 39, false);
#line 45 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(1458, 44, false);
#line 48 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.BuildName));

#line default
#line hidden
            EndContext();
            BeginContext(1502, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1594, 40, false);
#line 51 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.BuildName));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(1767, 39, false);
#line 54 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.Case));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1898, 35, false);
#line 57 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.Case));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(2066, 44, false);
#line 60 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.Processor));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2202, 40, false);
#line 63 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.Processor));

#line default
#line hidden
            EndContext();
            BeginContext(2242, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(2375, 47, false);
#line 66 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.GraphicsCard));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2514, 43, false);
#line 69 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.GraphicsCard));

#line default
#line hidden
            EndContext();
            BeginContext(2557, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(2690, 46, false);
#line 72 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.Motherboard));

#line default
#line hidden
            EndContext();
            BeginContext(2736, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2828, 42, false);
#line 75 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.Motherboard));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(3003, 41, false);
#line 78 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(3044, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3136, 37, false);
#line 81 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.Memory));

#line default
#line hidden
            EndContext();
            BeginContext(3173, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(3306, 55, false);
#line 84 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.NumberOfMemorySticks));

#line default
#line hidden
            EndContext();
            BeginContext(3361, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3453, 51, false);
#line 87 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.NumberOfMemorySticks));

#line default
#line hidden
            EndContext();
            BeginContext(3504, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(3637, 46, false);
#line 90 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.PowerSupply));

#line default
#line hidden
            EndContext();
            BeginContext(3683, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3775, 42, false);
#line 93 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.PowerSupply));

#line default
#line hidden
            EndContext();
            BeginContext(3817, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(3950, 48, false);
#line 96 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.HardDiskDrive));

#line default
#line hidden
            EndContext();
            BeginContext(3998, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4090, 44, false);
#line 99 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.HardDiskDrive));

#line default
#line hidden
            EndContext();
            BeginContext(4134, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(4267, 50, false);
#line 102 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.SolidStateDrive));

#line default
#line hidden
            EndContext();
            BeginContext(4317, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4409, 46, false);
#line 105 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.SolidStateDrive));

#line default
#line hidden
            EndContext();
            BeginContext(4455, 132, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt style=\"width:180px; margin-right: 20px;\">\r\n                            ");
            EndContext();
            BeginContext(4588, 45, false);
#line 108 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayNameFor(model => item.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(4633, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4725, 41, false);
#line 111 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                       Write(Html.DisplayFor(model => item.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(4766, 155, true);
            WriteLiteral("$\r\n                        </dd>\r\n                    </dl>\r\n                </td>\r\n\r\n                <td>\r\n                    <div class=\"text-center\">\r\n");
            EndContext();
            BeginContext(5224, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(5248, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc2caa385b704bec914834fb89dea535", async() => {
                BeginContext(5320, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 122 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5331, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 123 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                         if(signInManager.IsSignedIn(this.User)){
                            var userId = userManager.GetUserId(this.User);

                            

#line default
#line hidden
#line 126 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                             if (this.User.Identity.Name != item.Username && !item.UsersRatedIds.Contains(userId))
                            {

#line default
#line hidden
            BeginContext(5625, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(5657, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c5175bea20749bcadc7b4f15b5a43e0", async() => {
                BeginContext(5726, 4, true);
                WriteLiteral("Rate");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 128 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5734, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 129 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                            }

#line default
#line hidden
#line 130 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                             if (this.User.Identity.Name == item.Username)
                            {

#line default
#line hidden
            BeginContext(5874, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(5906, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f4c9cca0cec4903b3a2b4f5634c28d4", async() => {
                BeginContext(6000, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 132 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6010, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 133 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                            }

#line default
#line hidden
#line 133 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                             
                        }

#line default
#line hidden
            BeginContext(6070, 201, true);
            WriteLiteral("                    </div>\r\n                    <br />\r\n                    <div>\r\n                        <dl class=\"dl-horizontal\">\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(6272, 47, false);
#line 140 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                           Write(Html.DisplayNameFor(model => item.SystemRating));

#line default
#line hidden
            EndContext();
            BeginContext(6319, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(6423, 43, false);
#line 143 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                           Write(Html.DisplayFor(model => item.SystemRating));

#line default
#line hidden
            EndContext();
            BeginContext(6466, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(6470, 46, false);
#line 143 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                                                                          Write(Html.DisplayFor(model => item.MaxSystemRating));

#line default
#line hidden
            EndContext();
            BeginContext(6516, 103, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt>\r\n                                ");
            EndContext();
            BeginContext(6620, 45, false);
#line 146 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                           Write(Html.DisplayNameFor(model => item.UserRating));

#line default
#line hidden
            EndContext();
            BeginContext(6665, 103, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd>\r\n                                ");
            EndContext();
            BeginContext(6769, 41, false);
#line 149 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
                           Write(Html.DisplayFor(model => item.UserRating));

#line default
#line hidden
            EndContext();
            BeginContext(6810, 143, true);
            WriteLiteral(" / 10\r\n                            </dd>\r\n                        </dl>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 155 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Builds\All.cshtml"
        }

#line default
#line hidden
            BeginContext(6964, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PCBuilder.Common.Models.ViewModels.PCViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
