#pragma checksum "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aa8b7b07517a28cc1d91f90334fbcb712fedd08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escuela_Index), @"mvc.1.0.view", @"/Views/Escuela/Index.cshtml")]
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
#line 1 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/_ViewImports.cshtml"
using HolaMundoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/_ViewImports.cshtml"
using HolaMundoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa8b7b07517a28cc1d91f90334fbcb712fedd08", @"/Views/Escuela/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd844b5729bef53cbee2b226a2f3054d035bc852", @"/Views/_ViewImports.cshtml")]
    public class Views_Escuela_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Escuela>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
  
    ViewData["Title"] = "*****Información de Escuelas*****";
    //Layout = "_Layout";
    Layout = "_LayoutSimple";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> Escuela: ");
#nullable restore
#line 9 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Nombre: ");
#nullable restore
#line 10 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>Tipo escuela: ");
#nullable restore
#line 11 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
             Write(Model.TipoEscuela);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<address>\r\n    <p>Dirección: ");
#nullable restore
#line 14 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
             Write(Model.Dirección);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>País: ");
#nullable restore
#line 15 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
        Write(Model.Pais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Ciudad: ");
#nullable restore
#line 16 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
          Write(Model.Ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</address>\r\n\r\n<p><strong>Año fundación: ");
#nullable restore
#line 20 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
                     Write(Model.AñoDeCreación);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n<p><i>");
#nullable restore
#line 22 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
 Write(ViewBag.Bolsita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n\r\n<p><i>");
#nullable restore
#line 24 "/home/kali/Documents/Platzi/aspnetcore/SitioWebCursoAspNet/Views/Escuela/Index.cshtml"
 Write(ViewData["Bolsita"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i></p>\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bienvenido</h1>\r\n    <p>Conoce acerca de  <a href=\"https://docs.microsoft.com/aspnet/core\">Construyendo apliaciones con ASP.NET Core y su integración Git/Git Hub</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Escuela> Html { get; private set; }
    }
}
#pragma warning restore 1591
