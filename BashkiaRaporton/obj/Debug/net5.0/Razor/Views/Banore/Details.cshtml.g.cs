#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "060e8f32d6b98ef516ba5f02da9fc08bbdb93720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Banore_Details), @"mvc.1.0.view", @"/Views/Banore/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\_ViewImports.cshtml"
using BashkiaRaporton;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\_ViewImports.cshtml"
using BashkiaRaporton.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\_ViewImports.cshtml"
using BashkiaRaporton.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060e8f32d6b98ef516ba5f02da9fc08bbdb93720", @"/Views/Banore/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Banore_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BashkiaRaporton.Models.Banore>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"mb-3 row\">\r\n    <label for=\"staticEmail\" class=\"col-sm-4 col-form-label\">Emri</label>\r\n    <div class=\"col-sm-8\">\r\n        <input type=\"text\" readonly class=\"form-control-plaintext\" id=\"staticEmail\"");
            BeginWriteAttribute("value", " value=\"", 277, "\"", 297, 1);
#nullable restore
#line 9 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml"
WriteAttributeValue("", 285, Model.Email, 285, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div class=\"mb-3 row\">\r\n    <label for=\"staticEmail\" class=\"col-sm-4 col-form-label\">Mbiemri</label>\r\n    <div class=\"col-sm-8\">\r\n        <input type=\"text\" readonly class=\"form-control-plaintext\" id=\"staticEmail\"");
            BeginWriteAttribute("value", " value=\"", 534, "\"", 556, 1);
#nullable restore
#line 15 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml"
WriteAttributeValue("", 542, Model.Mbiemri, 542, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div class=\"mb-3 row\">\r\n    <label for=\"staticEmail\" class=\"col-sm-4 col-form-label\">Email</label>\r\n    <div class=\"col-sm-8\">\r\n        <input type=\"text\" readonly class=\"form-control-plaintext\" id=\"staticEmail\"");
            BeginWriteAttribute("value", " value=\"", 791, "\"", 811, 1);
#nullable restore
#line 21 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml"
WriteAttributeValue("", 799, Model.Email, 799, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div class=\"mb-3 row\">\r\n    <label for=\"staticEmail\" class=\"col-sm-4 col-form-label\">NjesiaAdministrative</label>\r\n    <div class=\"col-sm-8\">\r\n        <input type=\"text\" readonly class=\"form-control-plaintext\" id=\"staticEmail\"");
            BeginWriteAttribute("value", " value=\"", 1061, "\"", 1101, 1);
#nullable restore
#line 27 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml"
WriteAttributeValue("", 1069, Model.NjesiaAdministrative.Emri, 1069, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n<div class=\"mb-3 row\">\r\n    <label for=\"staticEmail\" class=\"col-sm-4 col-form-label\">Status</label>\r\n    <div class=\"col-sm-8\">\r\n        <input type=\"text\" readonly class=\"form-control-plaintext\" id=\"staticEmail\"");
            BeginWriteAttribute("value", " value=\"", 1337, "\"", 1366, 1);
#nullable restore
#line 33 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Details.cshtml"
WriteAttributeValue("", 1345, Model.Status.Statusi, 1345, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BashkiaRaporton.Models.Banore> Html { get; private set; }
    }
}
#pragma warning restore 1591
