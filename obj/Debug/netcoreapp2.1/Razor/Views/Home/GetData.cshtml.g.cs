#pragma checksum "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Home\GetData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409e60280f4b95f4f54156e10cbc4cd79d5b6f14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetData), @"mvc.1.0.view", @"/Views/Home/GetData.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetData.cshtml", typeof(AspNetCore.Views_Home_GetData))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"409e60280f4b95f4f54156e10cbc4cd79d5b6f14", @"/Views/Home/GetData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b66eb411a9618835f574c2d306170a8c010866", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 40, true);
            WriteLiteral("<h2>Detail Biodata</h2>\r\n\r\n<p>Nama anda ");
            EndContext();
            BeginContext(41, 17, false);
#line 3 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Home\GetData.cshtml"
        Write(ViewBag.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(58, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(60, 16, false);
#line 3 "C:\Users\InternshipProgram\Documents\WorkshopASPCoreUPNFeb2020\Views\Home\GetData.cshtml"
                           Write(ViewBag.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(76, 4, true);
            WriteLiteral("</p>");
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
