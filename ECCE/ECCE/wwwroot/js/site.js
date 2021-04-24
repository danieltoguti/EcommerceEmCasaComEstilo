// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function alertErro(texto) {
    swal("Erro", texto, "error")
}

function alertSucesso(texto) {
    swal("Bom Trabalho!", texto, "success");
}

function alertInformacao(texto) {
    swal("Verifique!", texto, "warning");
}


function somenteNumeros(num) {
    return num.replace(/[^\d]+/g, '');
}

function mascaraValor(valor, prefixo) {
    var sinal = "";
    if (Math.sign(valor) == -1)
        sinal = " -";

    valor = valor.toString().replace(/\D/g, "");
    valor = valor.toString().replace(/(\d)(\d{8})$/, "$1.$2");
    valor = valor.toString().replace(/(\d)(\d{5})$/, "$1.$2");
    valor = valor.toString().replace(/(\d)(\d{2})$/, "$1,$2");
    return prefixo + sinal + valor;
}


function SetMaskValor(e, mask, quant) {
    var mskPadrao = "999999999,00";

    if (mask != undefined) {
        mskPadrao = mask
    }

    e.mask("S#" + mskPadrao, {
        translation: {
            'S': {
                pattern: /-/,
                optional: true
            }
        }
    });
    e.blur(function () {
        e.val(FormatDecimal(e.val(), quant));
    });
}
function FormatDecimal(numero, quant) {
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

function NotifySucesso(Texto) {
    $.notify({
        icon: "<span class='material-icons'>thumb_up</span>",
        message: Texto,
    }, {
        z_index: 9999999,
        type: 'success',
        delay: 300,
        timer: 300,
        placement: {
            from: "bottom",
            align: "center"
        },

    });
}