#pragma checksum "J:\USMP\2021-II\Ingeniería de Software II\PROYECTO\PAGINA_WEB\FARMATODO_GRUPO4\Git_FarmatodoWeb\FarmatodoWeb\Views\Shared\_LayoutAcceso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b0b147c0ba9fbacb15982d9a51af8d3ed77ba74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutAcceso), @"mvc.1.0.view", @"/Views/Shared/_LayoutAcceso.cshtml")]
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
#line 1 "J:\USMP\2021-II\Ingeniería de Software II\PROYECTO\PAGINA_WEB\FARMATODO_GRUPO4\Git_FarmatodoWeb\FarmatodoWeb\Views\_ViewImports.cshtml"
using FarmatodoWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\USMP\2021-II\Ingeniería de Software II\PROYECTO\PAGINA_WEB\FARMATODO_GRUPO4\Git_FarmatodoWeb\FarmatodoWeb\Views\_ViewImports.cshtml"
using FarmatodoWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0b147c0ba9fbacb15982d9a51af8d3ed77ba74", @"/Views/Shared/_LayoutAcceso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1f52f5c8637750abe8ead166d2c0901862e72e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutAcceso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "J:\USMP\2021-II\Ingeniería de Software II\PROYECTO\PAGINA_WEB\FARMATODO_GRUPO4\Git_FarmatodoWeb\FarmatodoWeb\Views\Shared\_LayoutAcceso.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-8 offset-md-2 col-lg-6 offset-lg-3 col-xl-6 offset-xl-3"">
            <div class=""card login-logout-tab"" id=""panelAuto"">
                <div class=""card-header"">
                    <ul class=""nav nav-tabs card-header-tabs"">
                        <li class=""nav-item w-50"">
                            <a href=""/Acceso/IniciarSesion"" class=""nav-link text-center"">Iniciar Sesión</a>
                        </li>
                        <li class=""nav-item w-50"">
                            <a href=""/Acceso/CrearCuenta"" class=""nav-link text-center"">Crear Cuenta</a>
                        </li>
                    </ul>
                </div>
                <div class=""card-content"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
#nullable restore
#line 22 "J:\USMP\2021-II\Ingeniería de Software II\PROYECTO\PAGINA_WEB\FARMATODO_GRUPO4\Git_FarmatodoWeb\FarmatodoWeb\Views\Shared\_LayoutAcceso.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 32 "J:\USMP\2021-II\Ingeniería de Software II\PROYECTO\PAGINA_WEB\FARMATODO_GRUPO4\Git_FarmatodoWeb\FarmatodoWeb\Views\Shared\_LayoutAcceso.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script>
        $(function(){
            var current=location.pathname;
            $('.nav-tabs li a').each(function(){
                var $this=$(this);
                if(current.indexOf($this.attr('href'))!==-1){
                    //$this.removeClass(""active"");
                    $this.addClass('active_color');
                }else{
                    $this.addClass('inActive_color');
                }
            })
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
