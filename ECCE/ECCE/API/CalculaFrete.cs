using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECCE.API
{
    public class CalculaFrete
    {       
        public async Task<string> GetApi(string CepDestino, string CdServico)
        {            
            var CalcPrecoPrazo = new API_Correios.CalcPrecoPrazoWSSoapClient(API_Correios.CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap12);
            var resp=await  CalcPrecoPrazo.CalcPrecoAsync("", "", CdServico, "11790000", CepDestino, "2", 1, 20, 20, 20, 0, "N", 0, "N");
            try
            {
                if (resp.Servicos.Count() > 0)
                {
                    return resp.Servicos.FirstOrDefault().Valor;
                }
                else {
                    return "Verifique se o cep está correto!";
                }
            }
            catch {
                return "Erro ao Buscar";
            }




        }
      
    }




}
