#pragma checksum "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\Shared\_PublicLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3949c87b8bcd27952565528ea5a1fdb941943253"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PublicLayout), @"mvc.1.0.view", @"/Views/Shared/_PublicLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PublicLayout.cshtml", typeof(AspNetCore.Views_Shared__PublicLayout))]
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
#line 1 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\_ViewImports.cshtml"
using JaneTicar.GradeCourses.Web;

#line default
#line hidden
#line 2 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\_ViewImports.cshtml"
using JaneTicar.GradeCourses.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3949c87b8bcd27952565528ea5a1fdb941943253", @"/Views/Shared/_PublicLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27f52bc25933a650bee5cd5273b2d554fbb1c71", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PublicLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\Shared\_PublicLayout.cshtml"
  
    Layout = "~/views/shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 12, false);
#line 5 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\Shared\_PublicLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(69, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
            DefineSection("pageStyles", async() => {
                BeginContext(92, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(99, 44, false);
#line 7 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\Shared\_PublicLayout.cshtml"
Write(RenderSection("pageStyles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(143, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("pageScriptsTop", async() => {
                BeginContext(172, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(179, 48, false);
#line 10 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\Shared\_PublicLayout.cshtml"
Write(RenderSection("pageScriptsTop", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(227, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("pageScripts", async() => {
                BeginContext(253, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(260, 45, false);
#line 13 "C:\Users\Shayne Maravillo\source\repos\JaneTicar.GradeCourses\JaneTicar.GradeCourses.Web\Views\Shared\_PublicLayout.cshtml"
Write(RenderSection("pageScripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(305, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(308, 1, true);
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591