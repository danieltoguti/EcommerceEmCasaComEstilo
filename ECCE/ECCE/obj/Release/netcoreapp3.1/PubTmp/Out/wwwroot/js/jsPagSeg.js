function GetSessionPagSeg(ObjRetorno) {
    $.ajax({
        url: '/PagSeguro/GetSessaoPag',
        type: 'GET',
        processData: true,
        contentType: true,
        success: function (result) {            
            PagSeguroDirectPayment.setSessionId(result.sessionTk);                         
            ObjRetorno.val(result.sessionTk);
        }
    });
}

function GetMetodosPag(Valor, CbRetorno, divResp) {
    divResp.html("<div class='alert alert-light text-center' role='alert'><img src='/img/loading.gif' /> Aguarde...</div>");
    CbRetorno.html("");
    PagSeguroDirectPayment.getPaymentMethods({
        amount: FormatDecimalPagSeg(Valor).replace(",","."),
        success: function (response) {                        
            for (var k in response.paymentMethods) {
                var tipoPag = GetTipoPagamento(response.paymentMethods[k].code);
                if (tipoPag != "") {
                    if (response.paymentMethods[k].code == 1 || response.paymentMethods[k].code == 3) {
                        var o = new Option(tipoPag, response.paymentMethods[k].code);
                        CbRetorno.append(o);
                    }
                }
            }
            CbRetorno.change();
        },
        error: function (response) {
            // Callback para chamadas que falharam.
            console.log("erro GetMetodosPag=>");
            console.log(response);
        },
        complete: function (response) {
            divResp.html("");
        }
    });
}

function GetTipoPagamento(Code) {
    switch (Code) {
        case 2: return "BOLETO";
        case 3: return "CARTÃO DÉBITO";
        case 1: return "CARTÃO CRÉDITO";
        case 7: return "DEPÓSITO";
        default: return "";
    }
}

function GetBandeiraCC(CodCartao, divResp, objBandeira) {
    //divResp.html("<div class='alert alert-light text-center' role='alert'><img src='/img/loading.gif' /> Aguarde...</div>");
    CodCartao = somenteNumeros(CodCartao);    
    PagSeguroDirectPayment.getBrand({
        cardBin: CodCartao,
        success: function (response) {
            var resp = "https://stc.pagseguro.uol.com.br/public/img/payment-methods-flags/68x30/" + response.brand.name + ".png";
            divResp.html("<img src='" + resp + "'>");  
            objBandeira.val(response.brand.name);            
        },
        error: function (response) {            
        },
        complete: function (response) {
       //     divResp.html("");
        }
    });
}

function GetParcelamento(Valor, Bandeira, CbRetorno, divResp) {
    CbRetorno.html("");
    divResp.html("<div class='alert alert-light text-center' role='alert'><img src='/img/loading.gif' /> Aguarde...</div>");
    setTimeout(function () {        
        PagSeguroDirectPayment.getInstallments({
            amount: FormatDecimalPagSeg(Valor).replace(",","."),
            maxInstallmentNoInterest: 2,
            brand: Bandeira,
            success: function (response) {                
                for (var k in response.installments) {
                    console.log(response.installments);
                    for (var item in response.installments[k]) {
                        var qtd = response.installments[k][item].quantity;
                        var val_parcela = FormatDecimalPagSeg(response.installments[k][item].installmentAmount, 2);
                        var val_Total = FormatDecimalPagSeg(response.installments[k][item].totalAmount, 2);

                        var vAl = qtd + "|" + val_parcela;

                        var o = new Option(qtd + "x de R$" + val_parcela + " TOTAL => (R$" + val_Total + ")", vAl);
                        CbRetorno.append(o);
                    }
                }

            },
            error: function (response) {

            },
            complete: function (response) {
                divResp.html("");
            }
        });

    }, 2000);
}

function SenderHashReadyPGSeg(ObjRetorno) {
    PagSeguroDirectPayment.onSenderHashReady(function (response) {
        if (response.status == 'error') {
            console.log(response.message);
            return false;
        }
        var hash = response.senderHash;        
        ObjRetorno.val(hash);
    });
}

function createCardTokenPG(_Numero, _Bandeira, _CVV, _Mes, _ANO, ObjRetorno, divResp) {
    divResp.html("");
    _Numero = somenteNumeros(_Numero);  
    PagSeguroDirectPayment.createCardToken({
        cardNumber: _Numero,
        brand: _Bandeira,
        cvv: _CVV,
        expirationMonth: _Mes,
        expirationYear: parseInt("20"+_ANO),
        success: function (response) {            
            ObjRetorno.val(response.card.token);
        },
        error: function (response) {
            divResp.html("<div class='alert alert-danger' role='alert'>Cartão Inválido!</div>");              
        },
        complete: function (response) {
            // Callback para todas chamadas.
        }
    });
}

function FormatDecimalPagSeg(numero, quant) {
    try {
        if (numero == "") { numero = "0"; }
        if (String(numero).indexOf(",") > -1) {
            numero = numero.replace(".", "");
            numero = numero.replace(",", ".");
        }

        //numero = parseFloat(numero).toFixed(2);
        if (quant != undefined) {
            numero = parseFloat(numero).toFixed(quant).split('.');
        }
        else {
            numero = parseFloat(numero).toFixed(2).split('.');
        }

        numero[0] = numero[0].split(/(?=(?:...)*$)/).join('.');
        //return numero.join(',').replace(".", "");
        var resultv = numero.join(',').replace(".", "");

        resultv = resultv.replace(".", "");

        return resultv;
    }
    catch (e) {
        return "0";
    }
}