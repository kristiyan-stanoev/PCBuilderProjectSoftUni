#pragma checksum "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67e78a1c133637aa6d07e1ea741cd562bd7ccd9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_ProcessorViewModel), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/ProcessorViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/ProcessorViewModel.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_ProcessorViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e78a1c133637aa6d07e1ea741cd562bd7ccd9e", @"/Views/Shared/DisplayTemplates/ProcessorViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d02edabacccb3fb145a713897f7249996511045", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_ProcessorViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCBuilder.Common.Models.ViewModels.ProcessorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Processors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
  
    ViewData["Title"] = "ProcessorViewModel";

#line default
#line hidden
            BeginContext(116, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(165, 44, false);
#line 7 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Manufacturer));

#line default
#line hidden
            EndContext();
            BeginContext(209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(265, 41, false);
#line 10 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(306, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(362, 44, false);
#line 13 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Architecture));

#line default
#line hidden
            EndContext();
            BeginContext(406, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(462, 38, false);
#line 16 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Socket));

#line default
#line hidden
            EndContext();
            BeginContext(500, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(556, 45, false);
#line 19 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.NumberOfCores));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(657, 41, false);
#line 22 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Frequency));

#line default
#line hidden
            EndContext();
            BeginContext(698, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(754, 37, false);
#line 25 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Cache));

#line default
#line hidden
            EndContext();
            BeginContext(791, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(847, 37, false);
#line 28 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(884, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
            BeginContext(1007, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(1042, 45, false);
#line 34 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.MaxMemorySize));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1143, 37, false);
#line 37 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
           Write(Html.DisplayFor(model => Model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <div");
            EndContext();
            BeginWriteAttribute("style", " style=", 1239, "", 1313, 1);
#line 40 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
WriteAttributeValue("", 1246, this.User.IsInRole(WebConstants.AdminRole) ? "width:200px;" : "", 1246, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1313, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 41 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                     if (this.User.IsInRole(WebConstants.AdminRole))
                    {

#line default
#line hidden
            BeginContext(1409, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1433, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2900a33654f4be4ab27026c35bda803", async() => {
                BeginContext(1548, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(1556, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 44 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                    }

#line default
#line hidden
            BeginContext(1581, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1601, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f1c011cb3a4221b89a4d5c66165e75", async() => {
                BeginContext(1674, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1685, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                     if (this.User.IsInRole(WebConstants.AdminRole))
                    {

#line default
#line hidden
            BeginContext(1780, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1804, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceea6d1d66134225a96ace949cb982e0", async() => {
                BeginContext(1920, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                                                                             WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1930, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\Kristiyan\Desktop\PCBuilder\PCBuilder\PCBuilder.Web\Views\Shared\DisplayTemplates\ProcessorViewModel.cshtml"
                    }

#line default
#line hidden
            BeginContext(1955, 60, true);
            WriteLiteral("                </div>\r\n            </td>\r\n        </tr>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCBuilder.Common.Models.ViewModels.ProcessorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591