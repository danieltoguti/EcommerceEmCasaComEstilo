#pragma checksum "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Finalizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eabd6c256a8be13c8f4cb65a29b6fc8d5c2e7812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Finalizar), @"mvc.1.0.view", @"/Views/Home/Finalizar.cshtml")]
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
#line 1 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eabd6c256a8be13c8f4cb65a29b6fc8d5c2e7812", @"/Views/Home/Finalizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Finalizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "04510", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "04014", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Finalizar.cshtml"
   ViewData["Title"] = "Finalizar"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<br />\r\n<br />\r\n\r\n<hr />\r\n<h3>Escolher endereço de entrega</h3>\r\n<hr />\r\n\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    <aside class=\"col-lg-8\">\r\n\r\n        <div class=\"card mb-8\">\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eabd6c256a8be13c8f4cb65a29b6fc8d5c2e78124825", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Calculo de frete</label>
                        <div class=""input-group"">
                            <select id=""txt_servico"" type=""text"" class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eabd6c256a8be13c8f4cb65a29b6fc8d5c2e78125366", async() => {
                    WriteLiteral("PAC");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eabd6c256a8be13c8f4cb65a29b6fc8d5c2e78126618", async() => {
                    WriteLiteral("SEDEX");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <br>
                        <div class=""input-group"">
                            <input id=""txt_cep"" type=""text"" class=""form-control"" name=""CEP"" placeholder=""CEP"">
                            <span class=""input-group-append"">
                                <button id=""btn_Calcular"" type=""button"" class=""btn btn-primary"">Calcular</button>
                            </span>
                        </div>
                        <br>
                        <p>Valor do frete:  R$ <span id=""RespFrete""></span></p>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div> <!-- card-body.// -->
        </div> <!-- card.// -->
        <br />
        <br />
        <div class=""card mb-8"">
            <div class=""card-body"">
                <dl class=""dlist-align"">
                    <dt>Produtos: R$</dt>
                    <dd id=""ValorTotalProduto"" class=""text-right""></dd>
                </dl>
                <br><br>
                <dl class=""dlist-align"">
                    <dt>Frete: R$</dt>
                    <dd id=""RespFrete2"" class=""text-right text-danger""></dd>
                </dl>
                <br>
                <dl class=""dlist-align"">
                    <dt>Total: R$</dt>
                    <dd id=""ValorFinal"" class=""text-right text-dark b""><strong></strong></dd>
                </dl>

            </div> <!-- card-body.// -->
        </div> <!-- card.// -->

    </aside>
</div>

<br />
<br />

<hr />
<h3>Escolher forma de pagamento</h3>

<div>
    <aside class=""col-lg-8"">
        <div class=""card mb");
            WriteLiteral(@"-8"">
            <div class=""card-body"">
                    <div class=""form-group"">
                        <label>Selecione a forma de pagamento</label>
                        <div class=""input-group"">
                            <select id=""txt_pagamento"" type=""text"" class=""form-control"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eabd6c256a8be13c8f4cb65a29b6fc8d5c2e781210926", async() => {
                WriteLiteral("Cartão");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eabd6c256a8be13c8f4cb65a29b6fc8d5c2e781212118", async() => {
                WriteLiteral("Boleto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </select>
                        </div>
                    </div>
            </div> <!-- card-body.// -->
        </div> <!-- card.// -->
        <br />
        <br />

    </aside>
</div>
                <button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/home/Finalizar'"" style=""width:100%"">Efetuar Pagamento</button>

<hr />
<script>
    $(document).ready(function () {
        $(""#btn_Calcular"").click(function () {
            Calcular($(""#txt_cep"").val(), $(""#txt_servico"").val());
        });

        GetCarrinho();

    })

    function formata(v) {
        return v.toLocaleString(""pt-BR"", { minimumFractionDigits: 2 });
    }

    function Calcular(_cep, _servico) {
        $(""#RespFrete"").html(""Aguarde..."");
        var _url = '");
#nullable restore
#line 113 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Finalizar.cshtml"
               Write(Url.Action("GetCalculo", "CalculaFrete"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $.ajax({
            url: _url,
            type: 'GET',
            data: {
                cep : _cep,
                cdservico : _servico,
            },
            processData: true,
            contentType: true,
            success: function (result) {


                $(""#RespFrete"").html(result.resposta);
                $(""#RespFrete2"").html(result.resposta);
                SomaValorFreteProduto();

            }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            },
        });

    }
        function GetFoto(_CodigoProduto) {

        var _url = '");
#nullable restore
#line 143 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Finalizar.cshtml"
               Write(Url.Action("GetFoto", "Carrinho"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        $.ajax({
            url: _url,
            type: 'GET',
            processData: true,
            contentType: true,
            data: { CodigoProduto: _CodigoProduto },
            success: function (result) {
                if (result.success) {
                    $("".f_"" + _CodigoProduto).attr(""src"", result.caminho);
                }
                else {
                    return ""Caminho IMG"";
                }

             }
            ,
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }
        });
    }
    function GetCarrinho() {

        var tb = """";
        var Total = 0;
        var Quantidade = 0;
        $(""#idcarrinho"").html("""");
        var _url = '");
#nullable restore
#line 175 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Finalizar.cshtml"
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
                    tb = ""<tr>"";
                    $.each(result.resp, function (i, item) {
                        var f2 = item.preco.toLocaleString('pt-br', { minimumFractionDigits: 2 });
                        tb += ""<td><figure class='media'>"";
                        tb += ""<div class='img-wrap'><img class='f_"" + item.codigoProduto + ""' src=''class='img-thumbnail img-sm'></div>"";
                        tb += ""<figcaption class='media-body'>"";
                        tb += ""<h6 class='title text-truncate'>"" + item.nome + ""</h6>"";
                        tb += ""<dl class='dlist-inline small'><dt>Tamanho: </dt><dd>"" + item.tamanho + ""</dd></dl>"";
                        tb += ""<dl class='dlist-inline small'><dt>Cor: </dt><dd>"" + item.cor + ""</dd></dl>"";
                        t");
            WriteLiteral(@"b += ""</figcaption></figure ></td>"";
                        tb += ""<td>"" + item.quantidade + "" </td>"";
                        tb += ""<td><div class='price-wrap'><var class='price'>R$ "" + formata(item.quantidade * item.preco) + ""</var>"";
                        tb += ""<small class='text-muted'> R$ "" + f2 + "" cada</small></div></td>"";
                        tb += ""<td class='text-right'><a href='##' class='btn btn-light' onclick='RemoveItem("" + item.id + "");'>Remover</a></td>"";
                        tb += ""</tr>"";
                        Total += item.preco * item.quantidade;
                        Quantidade += item.quantidade;

                        $(""#ValorTotalProduto"").html(Total.toLocaleString('pt-br', { minimumFractionDigits: 2 }));
                        $(""#QuantidadeTotalProduto"").html(Quantidade);
                        $(""#idcarrinho"").html(tb);

                        GetFoto(item.codigoProduto);
                    });



                }
            }
            ");
            WriteLiteral(@",
            error: function (jqXHR) {

            },
            complete: function (jqXHR, status) {

            }

        });

    }


    function SomaValorFreteProduto() {
        var Frete = parseFloat($(""#RespFrete"").html());
        var TotalFinal = parseFloat($(""#ValorTotalProduto"").html());
        var Total = (Frete + TotalFinal).toLocaleString('pt-br', { minimumFractionDigits: 2 });
        $(""#ValorFinal"").html(Total);
    }

      function RemoveItem(codigo) {
        var _url = '");
#nullable restore
#line 234 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo0404\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Home\Finalizar.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
