#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\EditPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a52e36d11cc68cad82d7f8beac5e63e18aa1a7d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Taksas_EditPartial), @"mvc.1.0.view", @"/Views/Taksas/EditPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a52e36d11cc68cad82d7f8beac5e63e18aa1a7d6", @"/Views/Taksas/EditPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Taksas_EditPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BashkiaRaporton.Models.Taksa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group mt-2\"");
            BeginWriteAttribute("id", " id=\"", 66, "\"", 80, 1);
#nullable restore
#line 3 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\EditPartial.cshtml"
WriteAttributeValue("", 71, Model.Id, 71, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n        <input type=\"text\" id=\"pershkimi\" class=\"form-control col-6\"");
            BeginWriteAttribute("value", " value=\"", 236, "\"", 262, 1);
#nullable restore
#line 5 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\EditPartial.cshtml"
WriteAttributeValue("", 244, Model.Pershkrimin, 244, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 278, "\"", 362, 3);
            WriteAttributeValue("", 288, "EditSaveTaksa(\'", 288, 15, true);
#nullable restore
#line 6 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\EditPartial.cshtml"
WriteAttributeValue("", 303, Url.Action("EditTaksa","Taksas",new { id=Model.Id}), 303, 52, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 355, "\',this)", 355, 7, true);
            EndWriteAttribute();
            WriteLiteral("><span class=\"material-icons text-danger\">done</span></a>\r\n    </li>\r\n\r\n</ul>\r\n<script>\r\n    function EditSaveTaksa(url, result) {\r\n        var pershkrimi = $(\"#pershkimi\").val();\r\n\r\n        $.ajax(url, {\r\n            type: \'POST\',\r\n            data:{ id:");
#nullable restore
#line 16 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\EditPartial.cshtml"
                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" , Pershkrimin: pershkrimi},
            success: function (data, status, xhr) {

               
                $(result).parent().parent().parent().html(data);
            },
            error: function (jqXhr, textStatus, errorMessage) {
                alert(""Dicka shkoi gabim. kontaktoni suportin!"")
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BashkiaRaporton.Models.Taksa> Html { get; private set; }
    }
}
#pragma warning restore 1591