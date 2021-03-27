using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.API;
using Microsoft.AspNetCore.Mvc;

namespace EECE.Controllers
{

    public class CalculaFreteController : Controller
    {

        [HttpGet]
        public async Task<IActionResult> GetCalculo(string cep, string cdservico)
        {

            if (String.IsNullOrEmpty(cep))
            {
                return Json(new { status = false, resposta = "Infome um cep válido" });
            }

            CalculaFrete api = new CalculaFrete();                        
            var resp = await api.GetApi(cep, cdservico);
            return Json(new { status = true, resposta = resp });
        }

    }
}
