#pragma checksum "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ffc9bc6822dbfd31a1bbdef8cc728b18402e20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Taksas_Create), @"mvc.1.0.view", @"/Views/Taksas/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ffc9bc6822dbfd31a1bbdef8cc728b18402e20", @"/Views/Taksas/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8823f6d490dda36cc1781ff5a68de27d8f25f32a", @"/Views/_ViewImports.cshtml")]
    public class Views_Taksas_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BashkiaRaporton.Models.Taksa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h4>Krijo Takse</h4>
<div class=""row mt-4"">
    <div class=""col-md-12"">
      
           
            <div class=""form-group"">
               
                <input onchange=""AddTaksa()"" id=""Pershkrimin"" placeholder=""Shtoni nje Takse per Bashkine tuaj"" class=""form-control col-12"" />
                
            </div>
            
      
    </div>
</div>
<br />



   <script>
       function AddTaksa() {
           var Pershkrimin = $(""#Pershkrimin"").val();
          
           $.ajax('");
#nullable restore
#line 29 "C:\Users\User\source\repos\BashkiaRaporton\BashkiaRaporton\Views\Taksas\Create.cshtml"
              Write(Url.Action("CreateTaksa", "Taksas"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', {
               type: 'POST', 
               data: { Pershkrimin: Pershkrimin }, 
               success: function (data, status, xhr) {
                   location.reload(true);
               },
               error: function (jqXhr, textStatus, errorMessage) {
                  
               }
           });
       }
   </script>

       
   

");
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
