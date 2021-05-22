using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Classes;
using ECCE.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace ECCE.Controllers
{
    public class LoginController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public LoginController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        public async Task<IActionResult> Index(string redirect)
        {
            if (redirect !=null)
            {
                HttpContext.Session.SetString("redirect", redirect);
            }

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            await _hCont.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Logar(LoginAcesso obj, string redirect)
        {
            var resp = await CMetodos_Autenticacao.LoginValidoAsync(obj.Email, obj.Senha,_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;


            if (resp!="")
            {
                var Redirect = HttpContext.Session.GetString("redirect");
                if (!String.IsNullOrEmpty(Redirect))
                {
                    HttpContext.Session.Clear();
                    return RedirectToAction(Redirect, "Home");
                }

                if (resp == "A") {
                    return RedirectToAction("Index", "Home");
                }
                else if (resp == "C")
                {
                    return RedirectToAction("Index", "Home");
                }

                return null;

            }
            else
            {             
                ViewData["erro"] = "Falha no login!";
                return View("Index");
            }
        }
    }
}