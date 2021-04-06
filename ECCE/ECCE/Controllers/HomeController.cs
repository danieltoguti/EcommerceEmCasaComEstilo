using ECCE.Classes;
using ECCE.Data;
using ECCE.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _hCont = httpContextAccessor;
        }


        public IActionResult Index()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWList();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(resp);
        }
        public IActionResult Carrinho()
        {
            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = car.GetAll();

            return View();
        }


        public IActionResult ProdutoDetail(int id)
        {
            ProdutoDB Produto = new ProdutoDB();
            var resp = Produto.GetProdutoView(id);

            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            ViewData["Carrinho"] = car.GetAll();

            return View(resp);
        }


        public IActionResult Finalizar()
        {
            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = car.GetAll();

            if(ViewData["NomeLogin"] == "")
            {
                return RedirectToAction("index", "login");
            }
            else
            {
                return View();
            }

        }

        [Authorize(Roles = "A")]
        public IActionResult Dashboard()
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _hCont.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}