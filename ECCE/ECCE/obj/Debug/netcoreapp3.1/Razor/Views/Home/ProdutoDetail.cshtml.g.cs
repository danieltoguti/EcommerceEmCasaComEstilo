#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6281a4a8f0a250d344f577cb085076e513e4a1d4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6281a4a8f0a250d344f577cb085076e513e4a1d4", @"/Views/Home/ProdutoDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac77d2a601f4d58340855bb0b07dde3ca55643c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProdutoDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/pdp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick/slick.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pdp.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6281a4a8f0a250d344f577cb085076e513e4a1d45084", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"row\">\r\n        <aside class=\"col-md-6\">\r\n            <article class=\"gallery-wrap\">\r\n                <div class=\"product-slider-single normal-slider\">\r\n");
#nullable restore
#line 13 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                     foreach (var foto in Model.produtofotoModel)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                         if (foto.Caminho != "")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img id=\"foto\"");
            BeginWriteAttribute("src", " src=\"", 481, "\"", 502, 1);
#nullable restore
#line 17 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
WriteAttributeValue("", 487, foto.Descricao, 487, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image\">\r\n");
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"product-slider-single-nav normal-slider\">\r\n");
#nullable restore
#line 22 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                     foreach (var foto in Model.produtofotoModel)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                         if (foto.Caminho != "")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"slider-nav-img\"><img class=\"img-sm\"");
            BeginWriteAttribute("src", " src=\"", 913, "\"", 934, 1);
#nullable restore
#line 26 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
WriteAttributeValue("", 919, foto.Descricao, 919, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product Image\"></div>\r\n");
#nullable restore
#line 27 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </article> \r\n        </aside>\r\n        <main class=\"col-md-6 border-left\" style=\"padding: 2em 2em;\">\r\n            <article class=\"content-body\">\r\n\r\n                <h2 class=\"title\">");
#nullable restore
#line 35 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                             Write(Model.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                <div class=\"mb-3\">\r\n                    <var id=\"txt_preco\" class=\"price h4\">");
#nullable restore
#line 38 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                    Write(Model.tb_produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</var>\r\n                </div>\r\n\r\n                <p>");
#nullable restore
#line 41 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
              Write(Model.tb_produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <dl class=\"row\">\r\n                    <dt class=\"col-sm-4\">Código do produto</dt>\r\n                    <dd class=\"col-sm-8\">");
#nullable restore
#line 45 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                    Write(Model.tb_produto.CodigoInterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n                    <dt class=\"col-sm-4\">Cor</dt>\r\n                    <select id=\"txt_cor\" class=\"form-control col-sm-5\" style=\"width:130px\">\r\n\r\n");
#nullable restore
#line 50 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                         foreach (var Cor in Model.produtocorModel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d411766", async() => {
#nullable restore
#line 52 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                Write(Cor.Descricao);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n\r\n                    <br />\r\n                    <br />\r\n\r\n                    <dt class=\"col-sm-4\">Tamanho</dt>\r\n                    <select id=\"txt_tamanho\" class=\"form-control col-sm-5\" style=\"width:70px\">\r\n");
#nullable restore
#line 61 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                         foreach (var Tamanho in Model.produtotamanhoModel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d413863", async() => {
#nullable restore
#line 63 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                                                Write(Tamanho.Descricao);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>

                    <br />
                    <br />

                    <dt class=""col-sm-4"">Quantidade</dt>
                    <select id=""txt_quantidade"" class=""form-control"" style=""width:70px"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d415629", async() => {
                WriteLiteral("1");
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d416607", async() => {
                WriteLiteral("2");
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d417585", async() => {
                WriteLiteral("3");
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d418563", async() => {
                WriteLiteral("4");
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d419541", async() => {
                WriteLiteral("5");
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d420519", async() => {
                WriteLiteral("6");
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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d421497", async() => {
                WriteLiteral("7");
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
            WriteLiteral(@"
                    </select>

                </dl>

                <hr>

                <a onclick=""AddCar();"" href=""../Carrinho"" class=""btn  btn-primary""> Comprar agora </a>
                <a href=""#"" class=""btn  btn-outline-primary"" onclick=""AddCar();""> <span class=""text"">Adicionar ao carrinho</span> <i class=""fas fa-shopping-cart""></i>  </a>
            </article> <!-- product-info-aside .// -->
        </main> <!-- col.// -->
    </div> <!-- row.// -->
</div>

<div class=""row"" id=""idcarrinho""></div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d423000", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6281a4a8f0a250d344f577cb085076e513e4a1d424040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        var _foto = $(""#foto"").attr(""src"");
        var _tamanho = $(""#txt_tamanho option:selected"").val();
        var _cor = $(""#txt_cor option:selected"").val();
        var _quantidade = $(""#txt_quantidade option:selected"").val();
        //var _preco = '");
#nullable restore
#line 108 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                   Write(Model.tb_produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        //console.log(\"_preco é: \", _preco);\r\n\r\n        var _url = \'");
#nullable restore
#line 111 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
               Write(Url.Action("AddCar", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n        $.ajax({\r\n            url: _url,\r\n            type: \'GET\',\r\n            data: {\r\n                CodigoProduto: \'");
#nullable restore
#line 117 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                           Write(Model.tb_produto.CodigoProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Nome: \'");
#nullable restore
#line 118 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                  Write(Model.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Peso: \'");
#nullable restore
#line 119 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                  Write(Model.tb_produto.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                Tamanho: _tamanho,\r\n                Preco: \'");
#nullable restore
#line 121 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                   Write(Convert.ToDecimal(Model.tb_produto.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                Cor: _cor,
                Foto: _foto,
                Quantidade: _quantidade,
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
#line 147 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
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
                        tb += ""<div class='img-wrap'><img src='"" +  item.foto + ""' class='img-thumbnail img-sm'></div>"";
                        tb += ""<td>"" + item.nome + ""</td>"";
                        tb += ""<td>"" + item.quantidade + ""</td>"";
                        tb += ""<td>"" + item.tamanho + ""</td>"";
                        tb += ""<td>"" + item.preco + ""</td>"";
                        //console.log(""Esse está dentro do ajax "" + item.preco);
                        tb += ""<td>"" + item.cor + ""</td>"";
                        tb += ""<td><a href='##' onclick='RemoveItem("" + item.id + "");'>Remover</a></td>"";
                        tb +");
            WriteLiteral(@"= ""</tr>"";
                    });
                    tb += ""</table>"";
                    $(""#idcarrinho"").html(tb);
                }

             }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }
        });
        //console.log(""Depois"", '");
#nullable restore
#line 182 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
                            Write(Model.tb_produto.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\r\n    }\r\n\r\n\r\n    function RemoveItem(codigo) {\r\n        var _url = \'");
#nullable restore
#line 188 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\ProdutoDetail.cshtml"
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
