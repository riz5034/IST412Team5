#pragma checksum "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea1a4d219bc433d50626407b61be113019554b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectManager_CreateProject), @"mvc.1.0.view", @"/Views/ProjectManager/CreateProject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProjectManager/CreateProject.cshtml", typeof(AspNetCore.Views_ProjectManager_CreateProject))]
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
#line 1 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\_ViewImports.cshtml"
using WorkHourTracker.Web;

#line default
#line hidden
#line 2 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\_ViewImports.cshtml"
using WorkHourTracker.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea1a4d219bc433d50626407b61be113019554b73", @"/Views/ProjectManager/CreateProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af32e3fddc0a57e67e8d2736ec27801a8b0a433", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectManager_CreateProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkHourTracker.Web.Models.CreateProjectInput>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("MyProject"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("MyProj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveNewProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProjectManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
  
    ViewData["Title"] = "CreateProject";

#line default
#line hidden
            BeginContext(105, 165, true);
            WriteLiteral("<h2>CreateProject</h2>\r\n<p>Create a new project. Assign the project a name and code name.</p>\r\n<div class=\"container\">\r\n    <div class=\"form-group\">\r\n        <div>\r\n");
            EndContext();
#line 11 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
             if (TempData.Peek("CreateProjectSuccess") != null)
            {
                foreach (var message in (string[])TempData["CreateProjectSuccess"])
                {

#line default
#line hidden
            BeginContext(454, 44, true);
            WriteLiteral("                    <p style=\"color: green\">");
            EndContext();
            BeginContext(499, 7, false);
#line 15 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
                                       Write(message);

#line default
#line hidden
            EndContext();
            BeginContext(506, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 16 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(546, 31, true);
            WriteLiteral("        </div>\r\n        <div>\r\n");
            EndContext();
#line 20 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
             if (TempData.Peek("CreateProjectError") != null)
            {
                foreach (var message in (string[])TempData["CreateProjectError"])
                {

#line default
#line hidden
            BeginContext(757, 42, true);
            WriteLiteral("                    <p style=\"color: red\">");
            EndContext();
            BeginContext(800, 7, false);
#line 24 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
                                     Write(message);

#line default
#line hidden
            EndContext();
            BeginContext(807, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 25 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(847, 31, true);
            WriteLiteral("        </div>\r\n        <div>\r\n");
            EndContext();
#line 29 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
             if (TempData.Peek("CreateProjectInvalid") != null)
            {
                foreach (var message in (string[])TempData["CreateProjectInvalid"])
                {

#line default
#line hidden
            BeginContext(1062, 41, true);
            WriteLiteral("                    <p style=\"color:red\">");
            EndContext();
            BeginContext(1104, 7, false);
#line 33 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
                                    Write(message);

#line default
#line hidden
            EndContext();
            BeginContext(1111, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 34 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(1151, 24, true);
            WriteLiteral("        </div>\r\n        ");
            EndContext();
            BeginContext(1175, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56d3b497e10d4141992c59b76bb088f4", async() => {
                BeginContext(1241, 37, true);
                WriteLiteral("\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(1278, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecd5ed713d66483080003700bf34bb95", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 39 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1315, 45, true);
                WriteLiteral("\r\n                <div>\r\n                    ");
                EndContext();
                BeginContext(1360, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "750a88bd6030434da14fce8263ed4cc1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 41 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
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
                BeginContext(1427, 83, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(1510, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5265b6b075ec4ed6aeebe815140ff05a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 46 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectCodeName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1551, 45, true);
                WriteLiteral("\r\n                <div>\r\n                    ");
                EndContext();
                BeginContext(1596, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6837410dcffd4ce1809599289a5815b8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 48 "C:\Users\dds51\Desktop\SchoolWork\IST 412\WorkHourTrackerGitRepo\WorkHourTracker.Web\Views\ProjectManager\CreateProject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProjectCodeName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1664, 168, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <button type=\"submit\" class=\"btn-success\">Create</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 28, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkHourTracker.Web.Models.CreateProjectInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
