#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Njoftime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "084adc93869e49408130c36fbaf2891178805aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Banore_Njoftime), @"mvc.1.0.view", @"/Views/Banore/Njoftime.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084adc93869e49408130c36fbaf2891178805aa4", @"/Views/Banore/Njoftime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Banore_Njoftime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BashkiaRaporton.Models.Njoftime>
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
            WriteLiteral("<style>\r\n    .material-icons {\r\n        font-size: inherit;\r\n        top: 2px;\r\n        position: relative;\r\n    }\r\n</style>\r\n<ol class=\"breadcrumb\">\r\n\r\n    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "084adc93869e49408130c36fbaf2891178805aa44137", async() => {
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
    <li class=""breadcrumb-item active"">Njoftimet e mia</li>
</ol>

<div class=""col-12 row justify-content-between"">
    <div class=""col-md-6"">
        <input type=""search"" class=""form-control col-md-10"" id=""search"" placeholder=""Kerko Njoftime"" />
    </div>

</div>
<ul class=""list-group mt-2"">
    <li class=""list-group-item text-white bg-secondary"">
        <div class=""row"">
            <div class=""col-md-6"">
                <span class=""material-icons"">chat</span>   Mesazhi
            </div>
            <div class=""col-md-3"">
                <span class=""material-icons"">date_range</span>   Data e Dergimit
            </div>
            <div class=""col-md-3"">
                <span class=""material-icons"">remove_red_eye</span>  Shikushmeria
            </div>
        </div>

    </li>

</ul>
<div class=""njoftime"">

</div>
");
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
        $("".njoftime"").html('loading...');
                $.ajax({
                    url: """);
#nullable restore
#line 54 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Banore\Njoftime.cshtml"
                     Write(Url.Action("NjoftimePartial", "Banore"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?search="" + search + ""&pageNumber="" + page ,
                    success: function (result) {

                        $("".njoftime"").html(result);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BashkiaRaporton.Models.Njoftime> Html { get; private set; }
    }
}
#pragma warning restore 1591
