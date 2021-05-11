﻿using ECCE.Classes;
using ECCE.Data;
using ECCE.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MSAP.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public IActionResult Procura(string Nome)
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListProcura(Nome);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(resp);
        }

        public IActionResult Infantil()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListInfantil();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(resp);
        }

        public IActionResult Masculino()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListMasculino();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(resp);
        }

        public IActionResult Feminino()
        {

            ProdutoDB Prod = new ProdutoDB();
            var resp = Prod.GetProdutoVWListFeminino();

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


        public IActionResult PedidoConcluido()
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

            ViewData["ListTamanhoProd"] = Produto.GetTamanhoProduto(id);
            ViewData["Carrinho"] = car.GetAll();


            return View(resp);
        }

        public IActionResult GetQuantidadeProduto(int id)
        {
            ProdutoDB Produto = new ProdutoDB();
            var resp = Produto.GetQtdProduto(id);
            return Json(new { result = resp });
        }



        public async Task<IActionResult> Finalizar()
        {

            CarrinhoController car = new CarrinhoController(_hCont);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = car.GetAll();

            if (ViewData["NomeLogin"] == "")
            {
                return RedirectToAction("index", "login", new { redirect = "finalizar" });
            }
            else
            {
                var email = "eccestilo@gmail.com";
                var token = "21cad8a1-ea46-4fd3-9033-4da0e2f3b8e2520042e44d5da2bde3c350207fd55b9150fb-1682-4184-987c-c7ecbafe4ca7";
                var PagSeg = new CPagSeguro(email, token, CPagSeguro.eAmbiente.Producao);

                var resp = await PagSeg.GetSessaoAsync();
                ViewData["JsBPG"] = PagSeg.GetBiblioTecaJS();
                ViewData["TK"] = resp;

                ViewData["Enderecos"] = GetEnderecos();
                return View();
            }

        }

        public IActionResult FinalizarPedido()
        {
            try
            {
                var CodigoLogin = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin);


                return Json(new { success = true, msg = "Pedido Nº Finalizado!"});

            }
            catch (Exception)
            {
                return Json(new { success = false, msg = "Erro ao Cadastrar!" });
            }
        }

        public List<SelectListItem> GetEnderecos()
        {
            string sSQL = "";
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
            cn.Open();

            sSQL = "SELECT * FROM tb_endereco where CodigoLogin=@CodigoLogin";
            cmd.Parameters.AddWithValue("@CodigoLogin", CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
            cmd.CommandText = sSQL;
            cmd.Connection = cn;
            var Dr = cmd.ExecuteReader();

            List<SelectListItem> LT = new List<SelectListItem>();

            while (Dr.Read())
            {
                var Item = new SelectListItem()
                {
                    Value = Dr["CEP"].ToString(),
                    Text = Dr["Descricao"].ToString() + " - " +
                           Dr["Endereco"].ToString() + "," +
                           Dr["Numero"].ToString() +
                           " | CEP: " + Dr["CEP"].ToString()
                };

                LT.Add(Item);
            }

            return LT;
        }

        [Authorize(Roles = "A")]
        public IActionResult Dashboard()
        {
            ProdutoDB Produto = new ProdutoDB();
            var MLista = Produto.GetAllProduto();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            return View(MLista);
        }

        public async Task<IActionResult> Logout()
        {
            var Car = new CarrinhoController(_hCont);
            Car.RemoveAll();
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