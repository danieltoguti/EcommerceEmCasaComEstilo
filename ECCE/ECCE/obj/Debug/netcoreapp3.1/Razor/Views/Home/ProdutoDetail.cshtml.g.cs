#pragma checksum "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56cb098190b9d05aad86d259bb30cfa726c00ffa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProdutoDetail), @"mvc.1.0.view", @"/Views/Home/ProdutoDetail.cshtml")]
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
#line 1 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56cb098190b9d05aad86d259bb30cfa726c00ffa", @"/Views/Home/ProdutoDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProdutoDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pdp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick/slick.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pdp.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h5>");
#nullable restore
#line 6 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
Write(Model.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56cb098190b9d05aad86d259bb30cfa726c00ffa5076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""row"">
    <div class=""product-detail"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""product-detail-top"">
                        <div class=""row align-items-center"">
                            <div class=""col-md-5"">
                                <div class=""product-slider-single normal-slider"">
");
#nullable restore
#line 20 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                     foreach (var foto in Model.produtofotoModel)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                         if (foto.Caminho != "")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img");
            BeginWriteAttribute("src", " src=\"", 820, "\"", 841, 1);
#nullable restore
#line 24 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
WriteAttributeValue("", 826, foto.Descricao, 826, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image\">\r\n");
#nullable restore
#line 25 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"product-slider-single-nav normal-slider\">\r\n");
#nullable restore
#line 29 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                     foreach (var foto in Model.produtofotoModel)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                         if (foto.Caminho != "")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"slider-nav-img\" style=\"width: 45px\"><img");
            BeginWriteAttribute("src", " src=\"", 1401, "\"", 1422, 1);
#nullable restore
#line 33 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
WriteAttributeValue("", 1407, foto.Descricao, 1407, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image\"></div>\r\n");
#nullable restore
#line 34 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-7\">\r\n                                <div class=\"product-content\">\r\n                                    <div class=\"title\"><h2>");
#nullable restore
#line 40 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                      Write(Model.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n\r\n                                    <div class=\"price\">\r\n                                        <h4 id=\"txt_preco\">");
#nullable restore
#line 43 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                      Write(Model.tb_produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

                                    </div>
                                     <div class=""p-size"">
                                        <h4>Tamanho:</h4>
                                        <select id=""txt_tamanho"" class=""form-control"" style=""width:70px"">
");
#nullable restore
#line 49 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                             foreach (var Tamanho in Model.produtotamanhoModel)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cb098190b9d05aad86d259bb30cfa726c00ffa12023", async() => {
#nullable restore
#line 51 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                   Write(Tamanho.Descricao);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </select>
                                    </div>
                                    <div class=""p-size"">
                                        <h4>Cor:</h4>
                                        <select id=""txt_cor"" class=""form-control"" style=""width:130px"">
");
#nullable restore
#line 58 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                             foreach (var Cor in Model.produtocorModel)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cb098190b9d05aad86d259bb30cfa726c00ffa14227", async() => {
#nullable restore
#line 60 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                   Write(Cor.Descricao);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </select>
                                    </div>
                                    <div class=""action"">
                                        <a class=""btn cta"" style=""margin-right:11px;background:#28a745;color:#fff;font-size:12px;padding: 5px;"" href=""#"" onclick=""AddCar();""><i class=""fa fa-shopping-cart""></i>Adicionar ao carrinho</a>
                                        <a class=""btn cta"" style=""margin-right:11px;background:#28a745;color:#fff;font-size:12px;padding: 5px;"" href=""../Carrinho"" onclick=""AddCar();""><i class=""fa fa-shopping-bag""></i>Comprar</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""col-lg-6"">
                    <ul class=""nav nav-pills nav-justified"">
                        <li class=""nav-item"">
                            <a class=""nav-link acti");
            WriteLiteral(@"ve"" data-toggle=""pill"" href=""#description"">Descrição</a>
                        </li>


                    </ul>

                    <div class=""tab-content"">
                        <div id=""description"" class=""container tab-pane active"">
                            <p>
                                ");
#nullable restore
#line 86 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                           Write(Model.tb_produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </p>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\" id=\"idcarrinho\"></div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cb098190b9d05aad86d259bb30cfa726c00ffa17655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cb098190b9d05aad86d259bb30cfa726c00ffa18695", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $(document).ready(function () {
        GetCarrinho();
    });


    function AddCar() {        
        var _quantidade = $(""#txt_quantidade option:selected"").val();
        var _tamanho = $(""#txt_tamanho option:selected"").val();
        var _cor = $(""#txt_cor option:selected"").val();
        var foto = $(""#txt_foto"").val();
        var _url = '");
#nullable restore
#line 114 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
               Write(Url.Action("AddCar", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n        $.ajax({\r\n            url: _url,\r\n            type: \'GET\',\r\n            data: {\r\n                CodigoProduto: \'");
#nullable restore
#line 120 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                           Write(Model.tb_produto.CodigoProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Nome: \'");
#nullable restore
#line 121 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                  Write(Model.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Peso: \'");
#nullable restore
#line 122 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                  Write(Model.tb_produto.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Quantidade: _quantidade,\r\n                Tamanho: _tamanho,\r\n                Preco: \'");
#nullable restore
#line 125 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                   Write(Model.tb_produto.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Cor: _cor,\r\n                Foto: \'");
#nullable restore
#line 127 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                  Write(Model.produtofotoModel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            },
            processData: true,
            contentType: true,
            success: function (result) {
                GetCarrinho();
            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }

        });
    }

    function GetCarrinho() {

        var tb ="""";

        $(""#idcarrinho"").html("""");
        var _url = '");
#nullable restore
#line 150 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
               Write(Url.Action("GetAll", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            processData: true,
            contentType: true,
            success: function (result) {
                if (result.success) {
                    tb = ""<table class='table'>"";
                    $.each(result.resp, function (i, item) {
                        tb += ""<tr>"";
                        tb += ""<td>"" + item.nome + ""</td>"";
                        tb += ""<td>"" + item.quantidade + ""</td>"";
                        tb += ""<td>"" + item.tamanho + ""</td>"";
                        tb += ""<td>"" + item.preco + ""</td>"";
                        tb += ""<td>"" + item.cor + ""</td>"";
                        tb += ""<td><a href='##' onclick='RemoveItem("" + item.id + "");'>Remover</a></td>"";
                        tb += ""</tr>"";
                    });
                    tb += ""</table>"";
                    $(""#idcarrinho"").html(tb);
                }

             }
            ,
            error: function ");
            WriteLiteral("(jqXHR) {\r\n\r\n            },\r\n            complete: function (jqXHR, status) {\r\n\r\n            }\r\n\r\n        });\r\n    }\r\n\r\n\r\n    function RemoveItem(codigo) {\r\n        var _url = \'");
#nullable restore
#line 188 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-1\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
               Write(Url.Action("RemoveItem", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            data: {
                Id: codigo
            },
            processData: true,
            contentType: true,
            success: function (result) {
                GetCarrinho();
            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoView> Html { get; private set; }
    }
}
#pragma warning restore 1591
