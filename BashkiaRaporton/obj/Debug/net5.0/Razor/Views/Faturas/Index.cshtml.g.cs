#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Faturas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44eb0417bad3464ec011b15abaccbd0be6674d90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faturas_Index), @"mvc.1.0.view", @"/Views/Faturas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44eb0417bad3464ec011b15abaccbd0be6674d90", @"/Views/Faturas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Faturas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BashkiaRaporton.Models.Fatura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Faturas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .material-icons {\r\n        font-size: inherit;\r\n        top: 2px;\r\n        position: relative;\r\n    }\r\n</style>\r\n<ol class=\"breadcrumb\">\r\n\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44eb0417bad3464ec011b15abaccbd0be6674d904377", async() => {
                WriteLiteral("<span class=\"material-icons\">home</span>Kryefaqe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
    <li class=""breadcrumb-item active"">Fatura e Ujit</li>
</ol>

<div class=""col-12 row justify-content-between"">
    <div class=""col-md-6"">
        <input type=""search"" class=""form-control col-md-10"" id=""search"" placeholder=""Kerko Fature"" />
    </div>
    <div class=""col-md-6"">


        <a class=""nav-link col-4 float-right mb-3  btn btn-primary text-white""");
            BeginWriteAttribute("onclick", " onclick=\"", 753, "\"", 806, 3);
            WriteAttributeValue("", 763, "Display(\'", 763, 9, true);
#nullable restore
#line 26 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Faturas\Index.cshtml"
WriteAttributeValue("", 772, Url.Action("Create" ,"Faturas"), 772, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 804, "\')", 804, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Regjistro Fature<span class=""material-icons"">add_circle_outline</span></a>
    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""card-header"">

            </div>
            <div class=""modal-body"">

            </div>

        </div>
    </div>
</div>
<div class=""row border delete mr-2 ml-2 text-white bg-secondary"">
   
    <div class=""col-3 p-2"">
        <span class=""material-icons"">30fps_select</span>    Sasia
    </div>
    <div class=""col-3 p-2"">
        <span class=""material-icons"">person</span>   Banori
    </div>
    <div class=""col-3 p-2"">
        <span class=""material-icons"">calendar_today</span>   Data
    </div>
    <div class=""col-1 p-2"">
        <span class=""material-icons"">credit_score</span>   Pagesa
    </div>
    <div class=""col-1 p-2"">

    </div>
    <div ");
            WriteLiteral("class=\"col-1 p-2\">\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n<div class=\"fature\">\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    $.urlParam = function (name, url) {
        var results = new RegExp('[\?&]' + name + '=([^&#]*)').exec(url);
        if (results == null) {
            return null;
        }
        return decodeURI(results[1]) || 0;
    }
    function getUsers(page, search) {
        $("".fature"").html('loading...');
                $.ajax({
                    url: """);
#nullable restore
#line 83 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Faturas\Index.cshtml"
                     Write(Url.Action("IndexPartail", "Faturas"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?search="" + search + ""&pageNumber="" + page ,
                    success: function (result) {

                        $("".fature"").html(result);
                            $("".page-link"").click(function (e) {
                                e.preventDefault();
                                var hrefUrl = $(this).attr(""href"");
                                getUsers($.urlParam('pageNumber', hrefUrl), search);
                            });
                        }
                    });
    }
    $(document).ready(function () {

        getUsers(1, """");
    });

    $(""#search"").keyup(function () {
        if ($(this).val().length > 1) {
            getUsers(1, $(this).val());
        }
        else if ($(this).val().length == 0) {
            getUsers(1, """");
        }
    });

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BashkiaRaporton.Models.Fatura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
