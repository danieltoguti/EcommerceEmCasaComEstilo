#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce8c89d72282aeec5cefc9cc2eb4d9b9c56fe66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcao_Index), @"mvc.1.0.view", @"/Views/Funcao/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce8c89d72282aeec5cefc9cc2eb4d9b9c56fe66", @"/Views/Funcao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_funcionario_funcao>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
    ViewData["Title"] = "Função";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div >
    <table class=""table"">
        <tr>
            <th><h4>Funções</h4></th>
            <th></th>
            <th></th>
            <th class=""text-sm-right""><button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/funcao/cadastrofuncao'"">Nova Função</button>
            <th>
        </tr>
    </table>
");
#nullable restore
#line 19 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">

            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
                       Write(item.CodigoFuncao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1009, "\"", 1114, 5);
            WriteAttributeValue("", 1019, "window.location.href=\'/funcao/editar?CodigoFuncao=", 1019, 50, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
WriteAttributeValue("", 1069, item.CodigoFuncao, 1069, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1087, "&Descricao=", 1087, 11, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
WriteAttributeValue("", 1098, item.Descricao, 1098, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1113, "\'", 1113, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1209, "\"", 1289, 3);
            WriteAttributeValue("", 1219, "window.location.href=\'/funcao/excluir?CodigoFuncao=", 1219, 51, true);
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
WriteAttributeValue("", 1270, item.CodigoFuncao, 1270, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1288, "\'", 1288, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\n\n                    </tr>\n");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n");
#nullable restore
#line 44 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\n            Sem Registros!\n        </div>\n");
#nullable restore
#line 50 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Funcao\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_funcionario_funcao>> Html { get; private set; }
    }
}
#pragma warning restore 1591