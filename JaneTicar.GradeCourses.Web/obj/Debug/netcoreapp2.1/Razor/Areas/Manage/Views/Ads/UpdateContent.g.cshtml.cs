#pragma checksum "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6edeac99d81a1df5b0e595290ba1c0c5c05d1751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Ads_UpdateContent), @"mvc.1.0.view", @"/Areas/Manage/Views/Ads/UpdateContent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Ads/UpdateContent.cshtml", typeof(AspNetCore.Areas_Manage_Views_Ads_UpdateContent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edeac99d81a1df5b0e595290ba1c0c5c05d1751", @"/Areas/Manage/Views/Ads/UpdateContent.cshtml")]
    public class Areas_Manage_Views_Ads_UpdateContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Ads.UpdateContentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/ads/update-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/sceditor/themes/default.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("theme-style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/sceditor/sceditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/sceditor/icons/monocons.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/sceditor/formats/bbcode.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml"
  
    ViewData["Title"] = "UpdateContent";
    Layout = "~/Views/Shared/_PublicLayout.cshtml";

#line default
#line hidden
            BeginContext(188, 23, true);
            WriteLiteral("<br />\r\n<h3>Update Ad \"");
            EndContext();
            BeginContext(212, 11, false);
#line 7 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml"
          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(223, 67, true);
            WriteLiteral("\"</h3>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(290, 484, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "259f13e59f574a1c94e33e85f561b7e7", async() => {
                BeginContext(347, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(362, 24, false);
#line 13 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(386, 46, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"AdId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 432, "\"", 451, 1);
#line 14 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml"
WriteAttributeValue("", 440, Model.AdId, 440, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(452, 185, true);
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label for=\"Content\">Content</label>\r\n                <textarea id=\"content\" name=\"Content\" style=\"height:800px;width:700px;\">");
                EndContext();
                BeginContext(638, 13, false);
#line 17 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml"
                                                                                   Write(Model.Content);

#line default
#line hidden
                EndContext();
                BeginContext(651, 116, true);
                WriteLiteral("</textarea>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n        ");
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
            BeginContext(774, 710, true);
            WriteLiteral(@"
    </div>
</div>

<!--MODAL Attach-Image -->
<div class=""modal hide fade "" id=""modal-attach-image"">
    <div class=""modal-header"">
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
        <h5>Attach an image</h5>
    </div>
    <div class=""modal-body"">
        <p>Please select the image you want to attach.</p>
        <input type=""file"" class=""form-control"" name=""image"" id=""attachedImage"" />
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-success"" onclick=""attachImage()"">Yes</button>
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
    </div>
</div>

");
            EndContext();
            DefineSection("pageScripts", async() => {
                BeginContext(1505, 1168, true);
                WriteLiteral(@"
    <script>
        sceditor.command.set('attachimage', {
            exec: function () {
                $(""#modal-attach-image"").modal(""show"");
            },
            txtExec: function () {
                $(""#modal-attach-image"").modal(""show"");
            },
            tooltip: 'Insert an image from your computer'
        });
         var textarea = document.getElementById('content');
        sceditor.create(textarea, {
            format: 'bbcode',
            icons: 'monocons',
            toolbar: 'bold,italic,underline,strike,subscript,superscript|' +
                'left,center,right,justify|font,size,color,removeformat|' +
                'cut,copy,pastetext|bulletlist,orderedlist,indent,outdent|' +
                'table|code,quote,horizontalrule|' +
                'emoticon,youtube,date,time|ltr,rtl|image,attachimage',
            style: '~/vendor/sceditor/themes/content/default.min.css'
        });
         function attachImage() {
            var data = new FormDa");
                WriteLiteral("ta();\r\n            var file = $(\"#attachedImage\").prop(\'files\')[0];\r\n             data.append(\"image\", file);\r\n            data.append(\"adId\", \'");
                EndContext();
                BeginContext(2674, 10, false);
#line 66 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Areas\Manage\Views\Ads\UpdateContent.cshtml"
                            Write(Model.AdId);

#line default
#line hidden
                EndContext();
                BeginContext(2684, 927, true);
                WriteLiteral(@"');
             $.ajax({
                type: ""POST"",
                url: ""/manage/ads/attach-image"",
                processData: false,
                contentType: false,
                data: data,
                success: function (rsp) {
                    response = rsp.split(':');
                    if (response[0] === ""OK"") {
                        sceditor.instance(textarea).insert('[img]' + response[1] + '[/img]');
                    };
                },
                error: function (xhr) {
                    var response = JSON.parse(xhr.responseText);
                    alert(""Error Occured : "" + response.errors[0]);
                    location.reload();
                }
            });
             $(""#modal-attach-image"").modal(""hide"");
        }
         function getValue() {
            console.log(sceditor.instance(textarea).val());
        }
    </script>
");
                EndContext();
            }
            );
            DefineSection("pageScriptsTop", async() => {
                BeginContext(3638, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3644, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95a740213e4a4fc6979e798b93356eb8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3734, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3740, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ac6826549a04068883632a307d62aef", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3793, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3799, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14c8f17baace4025b8ad0350e0fcf069", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3858, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3864, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5fbb3a15c164ff8ba3b67ffba82b645", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3923, 855, true);
                WriteLiteral(@"
    <style>
        html {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 13px;
        }

        form div {
            padding: .5em;
        }

        code:before {
            position: absolute;
            content: 'Code:';
            top: -1.35em;
            left: 0;
        }

        code {
            margin-top: 1.5em;
            position: relative;
            background: #eee;
            border: 1px solid #aaa;
            white-space: pre;
            padding: .25em;
            min-height: 1.25em;
        }

            code:before, code {
                display: block;
                text-align: left;
            }

        .sceditor-button-attachimage div {
            background: url('~/vendor/sceditor/images/attachment.png');
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(4781, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Ads.UpdateContentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
