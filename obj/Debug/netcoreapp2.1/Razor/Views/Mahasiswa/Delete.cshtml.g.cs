#pragma checksum "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1763ab6a8bf06e2c2343269b639248e9174aea78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_Delete), @"mvc.1.0.view", @"/Views/Mahasiswa/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mahasiswa/Delete.cshtml", typeof(AspNetCore.Views_Mahasiswa_Delete))]
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
#line 1 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\_ViewImports.cshtml"
using WorkshopASPCore21;

#line default
#line hidden
#line 2 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\_ViewImports.cshtml"
using WorkshopASPCore21.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1763ab6a8bf06e2c2343269b639248e9174aea78", @"/Views/Mahasiswa/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b66eb411a9618835f574c2d306170a8c010866", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WorkshopASPCore21.Models.Mahasiswa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 59, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(103, 13, false);
#line 6 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
            EndContext();
            BeginContext(116, 47, true);
            WriteLiteral("\r\n        <h2>Delete Mahasiswa</h2>\r\n\r\n        ");
            EndContext();
            BeginContext(163, 1152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef0fe983b592452e973af7597da78552", async() => {
                BeginContext(203, 45, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"Nim\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 248, "\"", 266, 1);
#line 10 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 256, Model.Nim, 256, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(267, 146, true);
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label for=\"Nim\">Nim :</label>\r\n                <input type=\"text\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " \r\n                    value=\"", 413, "\"", 453, 1);
#line 14 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 443, Model.Nim, 443, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(454, 249, true);
                WriteLiteral(" readonly=\"readonly\" name=\"Nim\" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"Nama\">Nama :</label>\r\n                <input type=\"text\" class=\"form-control\" \r\n                name=\"Nama\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 703, "\"", 722, 1);
#line 19 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 711, Model.Nama, 711, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(723, 216, true);
                WriteLiteral(" />\r\n            </div>\r\n             <div class=\"form-group\">\r\n                <label for=\"IPK\">IPK :</label>\r\n                <input type=\"text\" class=\"form-control\" \r\n                name=\"IPK\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 939, "\"", 957, 1);
#line 24 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 947, Model.IPK, 947, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(958, 222, true);
                WriteLiteral(" />\r\n            </div>\r\n             <div class=\"form-group\">\r\n                <label for=\"Email\">Email :</label>\r\n                <input type=\"text\" class=\"form-control\" \r\n                name=\"Email\" readonly=\"readonly\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1180, "\"", 1200, 1);
#line 29 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Mahasiswa\Delete.cshtml"
WriteAttributeValue("", 1188, Model.Email, 1188, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1201, 107, true);
                WriteLiteral(" />\r\n            </div>\r\n            <button class=\"btn btn-danger\" name=\"action\">Delete</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1315, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkshopASPCore21.Models.Mahasiswa> Html { get; private set; }
    }
}
#pragma warning restore 1591