#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281e302847ab120ba57b20a4c9ce463e3572afd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NjesiaAdministratives_Edit), @"mvc.1.0.view", @"/Views/NjesiaAdministratives/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281e302847ab120ba57b20a4c9ce463e3572afd4", @"/Views/NjesiaAdministratives/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_NjesiaAdministratives_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BashkiaRaporton.Models.NjesiaAdministrative>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\" col-md-12\">\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"exampleInputEmail1\">Njesia</label>\r\n        <input type=\"text\" class=\"form-control\" id=\"emri\"");
            BeginWriteAttribute("value", " value=\"", 402, "\"", 421, 1);
#nullable restore
#line 12 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
WriteAttributeValue("", 410, Model.Emri, 410, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n       \r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Bashkia</label>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281e302847ab120ba57b20a4c9ce463e3572afd44652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 17 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BashkiaId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.BashkiaId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n   \r\n       \r\n        <a class=\"btn btn-success  text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 678, "\"", 758, 3);
            WriteAttributeValue("", 688, "EditSaveNjesi(\'", 688, 15, true);
#nullable restore
#line 21 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
WriteAttributeValue("", 703, Url.Action("EditNjesi","NjesiaAdministratives"), 703, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 751, "\',this)", 751, 7, true);
            EndWriteAttribute();
            WriteLiteral(">Edito Njesine</a>\r\n    \r\n</div>\r\n<script>\r\n    function EditSaveNjesi(url, result) {\r\n        var emri = $(\"#emri\").val();\r\n\r\n        $.ajax(url, {\r\n            type: \'POST\',\r\n            data: { id:");
#nullable restore
#line 30 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
                  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , Emri: emri, BashkiaId:");
#nullable restore
#line 30 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\NjesiaAdministratives\Edit.cshtml"
                                                    Write(Model.BashkiaId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"},
            success: function (data, status, xhr) {


                location.reload(true); 
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BashkiaRaporton.Models.NjesiaAdministrative> Html { get; private set; }
    }
}
#pragma warning restore 1591
