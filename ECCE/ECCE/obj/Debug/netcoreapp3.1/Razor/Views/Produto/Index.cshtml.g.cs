#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfdb3fc4173912a29f33fe0bf23c17a36442e79d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfdb3fc4173912a29f33fe0bf23c17a36442e79d", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
    ViewData["Title"] = "Produto";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div>
        <table class=""table"">
            <tr>
                <th><h4>Produtos</h4></th>
                <th></th>
                <th class=""text-sm-right""><button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/produto/cadastroproduto'"">Novo Produto</button>
                <th>
            </tr>
        </table>
");
#nullable restore
#line 19 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-sm"">
        <thead class=""thead-dark"">
            <tr>
                <th>Código Interno</th>
                <th>Nome</th>
                <th></th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 31 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 34 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
               Write(item.CodigoProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td></td>\n                <td>");
#nullable restore
#line 36 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><button type=\"button\" class=\"btn btn-warning btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1023, "\"", 1165, 7);
            WriteAttributeValue("", 1033, "window.location.href=\'/produto/editar?CodigoProduto=", 1033, 52, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1085, item.CodigoProduto, 1085, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1104, "&CodigoInterno=", 1104, 15, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1119, item.CodigoInterno, 1119, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1138, "&Descricao=", 1138, 11, true);
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
WriteAttributeValue("", 1149, item.Descricao, 1149, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1164, "\'", 1164, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-edit\"></i></button></td>\n            </tr>                \n");
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table> ");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
             }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-primary\" role=\"alert\">\n    Sem Registros!\n</div>");
#nullable restore
#line 46 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
