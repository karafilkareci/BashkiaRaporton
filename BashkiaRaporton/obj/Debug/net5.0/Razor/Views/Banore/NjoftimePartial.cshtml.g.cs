#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0881c430346e485f418bbb192d473cc8ca62b20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Banore_NjoftimePartial), @"mvc.1.0.view", @"/Views/Banore/NjoftimePartial.cshtml")]
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
#line 2 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
using BashkiaRaporton.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
using BashkiaRaporton.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0881c430346e485f418bbb192d473cc8ca62b20d", @"/Views/Banore/NjoftimePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Banore_NjoftimePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cloudscribe.Pagination.Models.PagedResult<BashkiaRaporton.Models.Njoftime>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
 foreach (var nj in Model.Data)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"list-group mt-1\">\r\n        <li class=\"list-group-item\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
               Write(nj.Mesazhi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
               Write(nj.DataDergimit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n");
#nullable restore
#line 18 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
                     if (nj.Shikushmeria == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Njoftim i vjeter</p>\r\n");
#nullable restore
#line 21 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input");
            BeginWriteAttribute("onchange", " onchange=\"", 787, "\"", 889, 4);
            WriteAttributeValue("", 798, "UpdateNjoftime(\'", 798, 16, true);
#nullable restore
#line 24 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
WriteAttributeValue("", 814, Url.Action("UpdateNjoftime","Njoftime"  , new { id=nj.NjoftimeId}), 814, 67, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 881, "\',this", 881, 6, true);
            WriteAttributeValue(" ", 887, ")", 888, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                               ");
#nullable restore
#line 25 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
                          Write(Njesia.CheckedNjoftime(context, nj.NjoftimeId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" asp-for=\"");
#nullable restore
#line 25 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
                                                                                   Write(nj.Shikushmeria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                               type=\"checkbox\"\r\n                               value=\"");
#nullable restore
#line 27 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
                                 Write(nj.Shikushmeria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 28 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </li>\r\n\r\n    </ul>\r\n");
#nullable restore
#line 37 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\NjoftimePartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function UpdateNjoftime(url, result) {
        $.ajax(url, {
            type: 'POST',
            data: { checked: result.checked },
            success: function (data, status, xhr) {
                location.reload();
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
        public ApplicationDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cloudscribe.Pagination.Models.PagedResult<BashkiaRaporton.Models.Njoftime>> Html { get; private set; }
    }
}
#pragma warning restore 1591
