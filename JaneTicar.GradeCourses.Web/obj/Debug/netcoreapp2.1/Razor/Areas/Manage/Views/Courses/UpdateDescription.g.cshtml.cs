#pragma checksum "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Courses\UpdateDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e797e3ffb9f0eb33bd67a432c8ef950ac0119bd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Courses_UpdateDescription), @"mvc.1.0.view", @"/Areas/Manage/Views/Courses/UpdateDescription.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Courses/UpdateDescription.cshtml", typeof(AspNetCore.Areas_Manage_Views_Courses_UpdateDescription))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e797e3ffb9f0eb33bd67a432c8ef950ac0119bd8", @"/Areas/Manage/Views/Courses/UpdateDescription.cshtml")]
    public class Areas_Manage_Views_Courses_UpdateDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Courses.UpdateDescriptionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/courses/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/courses/update-description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Courses\UpdateDescription.cshtml"
  
    ViewData["Title"] = "UpdateDescription";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(194, 25, true);
            WriteLiteral("\r\n<h2>UpdateDescription \"");
            EndContext();
            BeginContext(220, 11, false);
#line 7 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Courses\UpdateDescription.cshtml"
                  Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(231, 68, true);
            WriteLiteral("\"</h2>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"hero-unit\">\r\n        ");
            EndContext();
            BeginContext(299, 608, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43fb738138b446e18f62a06e008c6cc7", async() => {
                BeginContext(364, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(379, 24, false);
#line 13 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Courses\UpdateDescription.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(403, 50, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"CourseId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 453, "\"", 476, 1);
#line 14 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Courses\UpdateDescription.cshtml"
WriteAttributeValue("", 461, Model.CourseId, 461, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(477, 203, true);
                WriteLiteral(" />\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"Description\">Description</label>\r\n                <textarea id=\"description\" name=\"Description\" style=\"height:800px;width:700px;\">");
                EndContext();
                BeginContext(681, 17, false);
#line 18 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Courses\UpdateDescription.cshtml"
                                                                                           Write(Model.Description);

#line default
#line hidden
                EndContext();
                BeginContext(698, 126, true);
                WriteLiteral("</textarea>\r\n            </div>\r\n\r\n\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(824, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69b96f43e3db4feea9284eec3a91483e", async() => {
                    BeginContext(880, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
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
                EndContext();
                BeginContext(890, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(907, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Courses.UpdateDescriptionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
