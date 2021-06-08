﻿using ECCE.Classes;
using ECCE.Data;
using ECCE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        public ProdutoController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }
        [Authorize(Roles = "A")]
        public IActionResult Index()
        {
            ProdutoDB Produto = new ProdutoDB();
            var MLista = Produto.GetAllProduto();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }


        public IActionResult Produto(int id)
        {
            ProdutoDB Produto = new ProdutoDB();
            var resp = Produto.GetProdutoView(id);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            ViewData["Carrinho"] = GetAll();

            return View(resp);
        }

        public string GetAll()
        {
            string Carrinho = "<table>";
            foreach (var item in Request.Cookies)
            {
                Carrinho += "<tr>";
                Carrinho += "<td>" + item.Key + "</td>";
                Carrinho += "<td>" + item.Value + "</td>";
                Carrinho += "<td><a href='##' onclick='RemoveItem(" + item.Key + ");'>Excluir</a></td>";
                Carrinho += "</tr>";
            }
            Carrinho += "</table>";
            return Carrinho;
        }

        [HttpGet]
        public void RemoveItem(string key)
        {
            Response.Cookies.Delete(key);
        }

        [HttpGet] //AQUIE SE QUISER UM ITEM ESPECÍFICO 
        public string Get(string key)
        {
            return Request.Cookies[key];
        }

        [Authorize(Roles = "A")]
        public IActionResult CadastroProduto()
        {
            ProdutoDB Gen = new ProdutoDB();
            ProdutoDB Tam = new ProdutoDB();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);
            ViewData["LTGenero"] = Gen.GetGenero();
            ViewData["LTTam"] = Tam.GetTamanho();

            ViewData["Valida"] = "";
            return View();
        }

        [Authorize(Roles = "A")]
        public IActionResult Editar(int CodigoProduto)
        {
            ProdutoDB Gen = new ProdutoDB();
            ProdutoDB Tam = new ProdutoDB();

            ViewData["LTGenero"] = Gen.GetGenero();
            ViewData["LTTam"] = Tam.GetTamanho();

            ProdutoDB Prod = new ProdutoDB();

            var resp = Prod.GetProduto(CodigoProduto);
            resp.JsonLTGenero = resp.JsonLTGenero.Replace("CodigoGenero", "Codigo");

            return View("CadastroProduto", resp);
        }

        [Authorize(Roles = "A")]
        public IActionResult Salvar(ProdutoModel obj)
        {
            string smgvalida = Validar(obj);
            if (smgvalida != "")
            {
                return Json(new { success = false, msg = smgvalida });
            }

            ProdutoDB Prod = new ProdutoDB();

            if (obj.tb_produto.CodigoProduto == 0)
            {
                if (Prod.ValidarTamanho(obj))
                {
                    return Json(new { success = false, msg = "Erro ao Cadastrar!" });
                }
                else if (Prod.InserirDados(obj))
                {
                    return Json(new { success = true, msg = "Produto Cadastrado com Sucesso!" });
                }
                else
                {
                    return Json(new { success = false, msg = "Erro ao Cadastrar!" });
                }
            }
            else
            {
                if (Prod.UpdateDados(obj))
                {
                    return Json(new { success = true, msg = "Produto Atualizado com Sucesso!" });
                }
                else if (Prod.ValidarTamanho(obj))
                {

                    if (Prod.UpdateDados(obj))
                    {
                        return Json(new { success = true, msg = "Produto Atualizado com Sucesso!" });
                    }
                    else
                    {
                        return Json(new { success = false, msg = "Erro ao Cadastrar!" });
                    }
                }
                else
                {
                    return Json(new { success = false, msg = "Erro ao Cadastrar!" });
                }
            }

            return Json(new { success = false, msg = "Erro ao Cadastrar!" });
        }

        public string Validar(ProdutoModel obj)
        {

            ProdutoDB Produto = new ProdutoDB();

            if (String.IsNullOrEmpty(obj.tb_produto.Nome))
            {
                return "Digite o nome do produto";
            }

            if (obj.tb_produto.Valor <= 0)
            {
                return "O Preço é inválido!";
            }

            return "";
        }
    }
}
