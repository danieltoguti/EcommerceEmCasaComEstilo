using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MSAP.Classes
{
    public class CPagSeguro
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public eAmbiente TipoAmbiente { get; set; }

        public enum eAmbiente
        {
            Producao,
            SandBox
        }


        public enum eProviders
        {
            sessions,
            transactions,
            cancels,
            refunds
        }


        public CPagSeguro(string Email_PS, string Token_PS, eAmbiente Ambiente)
        {
            Email = Email_PS;
            Token = Token_PS;
            TipoAmbiente = Ambiente;
        }

        private string GetAmbiente(eAmbiente TipoAmbiente)
        {
            switch (TipoAmbiente)
            {
                case eAmbiente.Producao:
                    return "https://ws.pagseguro.uol.com.br/v2/";

                case eAmbiente.SandBox:
                    return "https://ws.sandbox.pagseguro.uol.com.br/v2/";
            }

            return "";
        }


        public string GetBiblioTecaJS()
        {

            switch (TipoAmbiente)
            {
                case eAmbiente.Producao:
                    return "<script type='text/javascript' src='https://stc.pagseguro.uol.com.br/pagseguro/api/v2/checkout/pagseguro.directpayment.js'></script>";

                case eAmbiente.SandBox:
                    return "<script type='text/javascript' src='https://stc.sandbox.pagseguro.uol.com.br/pagseguro/api/v2/checkout/pagseguro.directpayment.js'></script>";
            }

            return "";
        }


        public async Task<string> GetSessaoAsync()
        {

            var values = new Dictionary<string, string>
            {
               { "email", Email },
               { "token", Token}
            };


            var responseString = await SendPost(values, eProviders.sessions);

            try
            {
                System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument();
                xmldoc.LoadXml(responseString);
                var resp = xmldoc.GetElementsByTagName("id")[0].InnerText;
                return resp;
            }

            catch
            {

            }

            return "Aguardando..";
        }

        

        public bool StatusEnvio(string Conteudo)
        {
            try
            {
                System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument();
                xmldoc.LoadXml(Conteudo);

                if (xmldoc.GetElementsByTagName("status").Count > 0)
                {
                    var resp = xmldoc.GetElementsByTagName("status")[0].InnerText;

                    if (resp == "1")
                    {
                        return true;
                    }
                }
            }
            catch
            {

            }
            return false;
        }

        public string CodigoTransacaoEnvio(string Conteudo)
        {
            try
            {
                System.Xml.XmlDocument xmldoc = new System.Xml.XmlDocument();
                xmldoc.LoadXml(Conteudo);

                if (xmldoc.GetElementsByTagName("code").Count > 0)
                {
                    var resp = xmldoc.GetElementsByTagName("code")[0].InnerText;

                    return resp;

                }

            }
            catch
            {

            }
            return "";
        }


        public List<SelectListItem> GetTipoPagamento()
        {
            var LT = new List<SelectListItem>()
            {
                new SelectListItem(){Value = "2", Text = "BOLETO" },
                new SelectListItem(){Value = "3", Text = "CARTÃO DÉBITO" },
                new SelectListItem(){Value = "1", Text = "CARTÃO CRÉDITO" },
                new SelectListItem(){Value = "7", Text = "DEPÓSITO" },
            };


            return LT;
        }



        public async Task<string> SendPost(Dictionary<string, string> Parametros, eProviders Tipo)
        {

            string Url = GetAmbiente(TipoAmbiente) + Tipo.ToString();

            HttpClient client = new HttpClient();
            var content = new FormUrlEncodedContent(Parametros);           

            var response = await client.PostAsync(Url, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }



        public async Task<string> SendPostOK(Dictionary<string, string> Parametros, eProviders Tipo)
        {

            string Url = GetAmbiente(TipoAmbiente) + Tipo.ToString();

            HttpClient client = new HttpClient();
            var content = new FormUrlEncodedContent(Parametros);

            content.Headers.ContentType.CharSet = "ISO-8859-1";

            var response = await client.PostAsync(Url, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        public async Task<string> GetTransaction(string CodigoTransacao)
        {
           
            string Url = GetAmbiente(TipoAmbiente).Replace("v2", "v3") + "transactions/" + CodigoTransacao +"?email="+Email+"&token="+Token; 

            HttpClient client = new HttpClient();
         
            var response = await client.GetAsync(Url);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}

