#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c90a74fbb2bfc0e4976389e141584a9dfd0b2b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c90a74fbb2bfc0e4976389e141584a9dfd0b2b47", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_login>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    ViewData["Title"] = "Produto";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <table class=\"table\">\n        <tr>\n            <th><h4>Clientes</h4></th>\n            <th></th>\n            <th></th>\n            <th></th>\n        </tr>\n    </table>\n");
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">

            <thead>
                <tr>
                    <th></th>
                    <th>Código</th>
                    <th>Nome</th>
                    <th>Email</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td></td>\n                    <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                   Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 924, "\"", 1141, 17);
            WriteAttributeValue("", 934, "window.location.href=\'/usuario/editaradmin?CodigoLogin=", 934, 55, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 989, item.CodigoLogin, 989, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1006, "&Nome=", 1006, 6, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1012, item.Nome, 1012, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1022, "&Email=", 1022, 7, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1029, item.Email, 1029, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1040, "&Telefone=", 1040, 10, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1050, item.Telefone, 1050, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1064, "&CPF_CNPJ=", 1064, 10, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1074, item.CPF_CNPJ, 1074, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1088, "&Senha=", 1088, 7, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1095, item.Senha, 1095, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1106, "&Tipo=", 1106, 6, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1112, item.Tipo, 1112, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1122, "&Ativo=", 1122, 7, true);
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 1129, item.Ativo, 1129, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1140, "\'", 1140, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\n                    <!--   <td><button type=\"button\" class=\"btn btn-warning\" onclick=\"window.location.href=\'/usuario/editar?CodigoLogin=");
#nullable restore
#line 40 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                                                                                                                                   Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("&Descricao=");
#nullable restore
#line 40 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                                                                                                                                                               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\">Editar</button></td>\n        <td><button type=\"button\" class=\"btn btn-danger\" onclick=\"window.location.href=\'/usuario/excluir?CodigoLogin=");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                                                                                                                Write(item.CodigoLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\">Excluir</button></td>\n    -->\n                </tr>\n");
#nullable restore
#line 44 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 47 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\n            Sem Registros!\n        </div>\n");
#nullable restore
#line 53 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Usuario\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_login>> Html { get; private set; }
    }
}
#pragma warning restore 1591
