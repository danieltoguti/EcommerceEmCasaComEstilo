using ECCE.Classes;
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
    public class PedidoController : Controller
    {

        private readonly IHttpContextAccessor _hCont;
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _hCont = httpContextAccessor;
        }

        [Authorize(Roles = "A")]
        public IActionResult Index()
        {
            FinalizarPedidoDB Pedido = new FinalizarPedidoDB();
            var MLista = Pedido.ListarPedidos();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);



            return View(MLista);
        }

        [Authorize(Roles = "A")]
        public IActionResult VerItens(int CodigoVenda)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            FinalizarPedidoDB Itens = new FinalizarPedidoDB();
            var model = Itens.GetItemVenda(CodigoVenda);

            ViewData["Valida"] = "";
            return View("ItensPedido", model);

        }

        public IActionResult VerIten(int CodigoVenda)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);
            try
            {
                var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
                string smgvalida = Validar(cod, CodigoVenda);
                if (smgvalida != "")
                {
                    var _Carrinho = new CarrinhoController(_hCont);
                    var RespCar = _Carrinho.GetAllDB();
                    ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
                    FinalizarPedidoDB Itens = new FinalizarPedidoDB();
                    var model = Itens.GetItemVenda(CodigoVenda);

                    ViewData["Valida"] = "";
                    return View("ItensPedidoCliente", model);
                }
                return RedirectToAction("index", "home");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }


        public string Validar(int codigo, int codVenda)
        {
            FinalizarPedidoDB cod = new FinalizarPedidoDB();
            if (cod.ValidarNome(codigo, codVenda))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Sem permição</div>";
            }
            return "";
        }


        public IActionResult ItensPedido()
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;


            ViewData["Valida"] = "";
            return View();

        }

        [Authorize(Roles = "A")]
        public IActionResult Editar(int CodigoVenda, string Status)
        {
            var model = new tb_venda();
            model.CodigoVenda = CodigoVenda;
            model.Status = Status;
            ViewData["Valida"] = "";
            return View("EditarStatus", model);
        }

        [Authorize(Roles = "A")]
        public IActionResult Salvar(tb_venda obj)
        {
            FinalizarPedidoDB Venda = new FinalizarPedidoDB();

            if (Venda.UpDateStatus(obj))
            {
                ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Status atualizado com sucesso!</div>";
            }
            else
            {
                ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Status!</div>";
            }

            return View("EditarStatus");
        }

    }
}
