#pragma checksum "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa441cc747d59a9c9013b20b80bd9112e3b93944"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinos_Index), @"mvc.1.0.view", @"/Views/Destinos/Index.cshtml")]
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
#line 1 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\_ViewImports.cshtml"
using SiteAgencia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\_ViewImports.cshtml"
using SiteAgencia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa441cc747d59a9c9013b20b80bd9112e3b93944", @"/Views/Destinos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05da93385970a294e26b63222d0ae1c8961dfc9", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SiteAgencia.Models.Destinos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
  
    ViewData["Title"] = "Destinos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"container d-flex flex-wrap mt-5 justify-content-center\">\r\n");
#nullable restore
#line 9 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     <!--Card de viagens-->
            <section class=""col-12 col-md-6 col-lg-3 mt-4"">
                <section class=""bg-white border border-2 mt-1 d-flex flex-wrap align-items-center justify-content-center p-2 text-white h-100"">
                    <h2 class=""text-danger text-center w-100"">");
#nullable restore
#line 13 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"cards-section overflow-hidden h-50\">\r\n                        <p class=\"bg-white p-2 text-dark text-center h-100 \">\r\n                            ");
#nullable restore
#line 16 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <span> ");
#nullable restore
#line 18 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \r\n                    </div>\r\n                    <!-- Button trigger modal -->\r\n                    <a");
            BeginWriteAttribute("href", "  href=\"", 1031, "\"", 1134, 2);
            WriteAttributeValue("", 1039, "https://api.whatsapp.com/send?phone=5571985011600&text=Quero%20viajar%20para%20", 1039, 79, true);
            WriteAttributeValue("", 1118, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                                                               
#nullable restore
#line 21 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
                                                                                                          Write(item.Destino);

#line default
#line hidden
#nullable disable
                                                                                                                                            
                PopWriter();
            }
            ), 1118, 16, false);
            EndWriteAttribute();
            WriteLiteral(" target=\"_brank\" class=\"btn btn-success w-50 m-5\">Viajar</a>\r\n                </section>\r\n            </section>\r\n            <!--Card de viagens FINAL-->\r\n");
#nullable restore
#line 25 "C:\Users\Japa\Desktop\Projeto Agencias\Projeto-AgenciaViagem\SiteAgencia\Views\Destinos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SiteAgencia.Models.Destinos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
