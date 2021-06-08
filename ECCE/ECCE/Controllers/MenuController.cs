using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;
using ECCE.Classes;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ECCE.Controllers
{
    public class MenuController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public MenuController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        public IActionResult MeusPedidos()
        {
            try
            {
                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);
                /*=============*/
                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
                /*============*/
                if (ViewData["NomeLogin"] != "")
                {
                    FinalizarPedidoDB Pedido = new FinalizarPedidoDB();
                    var MLista = Pedido.ListarPedidosCliente(cod);

                    return View(MLista);
                }
                return RedirectToAction("index");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }
        public IActionResult AddEndereco()
        {
            try
            {
                ViewData["Valida"] = "";
                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

                if (ViewData["NomeLogin"] != "")
                {
                    return View();
                }
                return RedirectToAction("index", "home");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }

        public IActionResult EditaSSenha()
        {
            try
            {
                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
                if (ViewData["NomeLogin"] != "")
                {
                    var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));

                    UsuarioDB Usuario = new UsuarioDB();
                    var model = Usuario.GetUsuario(cod);
                    model.JsonLTEDR = JsonConvert.SerializeObject(model.tb_endereco);

                    ViewData["Valida"] = "";
                    return View("AtualizaCadastro", model);
                }
                return RedirectToAction("index", "home");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }

        public IActionResult Endereco()
        {
            try
            {
                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
                if (ViewData["NomeLogin"] != "")
                {
                    var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));

                    UsuarioDB Usuario = new UsuarioDB();
                    var model = Usuario.GetEnderecos(cod);

                    ViewData["Valida"] = "";
                    return View(model);
                }
                return RedirectToAction("index", "home");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }

        public IActionResult EditarEnd(int CodigoEnd)
        {
            try
            {
                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
                var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
                string smgvalida = Validar(cod, CodigoEnd);
                if (smgvalida != "")
                {
                    UsuarioDB End = new UsuarioDB();

                    var resp = End.GetEndereco(CodigoEnd);
                    return View("CadastroEndereco", resp);
                }
                return RedirectToAction("index", "home");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }

        public string Validar(int codigo, int codEnd)
        {
            FinalizarPedidoDB cod = new FinalizarPedidoDB();
            if (cod.ValidarNomeEnd(codigo, codEnd))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Sem permição</div>";
            }
            return "";
        }

        public IActionResult SalvarEnde(tb_endereco obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            UsuarioDB Usu = new UsuarioDB();

            if (Usu.UpdateEndereco(obj))
            {
                ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Endereço atualizado com sucesso!</div>";
            }
            else
            {
                ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar endereço!</div>";
            }
            return View("CadastroEndereco");

        }

        public IActionResult CadastroEndereco()
        {
            try
            {
                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

                return View();
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }

        public IActionResult DesativarEndereco(int CodigoEnd)
        {
            try
            {
                ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
                ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


                var _Carrinho = new CarrinhoController(_hCont);
                var RespCar = _Carrinho.GetAllDB();
                ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
                var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
                string smgvalida = Validar(cod, CodigoEnd);
                if (smgvalida != "")
                {
                    UsuarioDB End = new UsuarioDB();

                    var resp = End.UpdateEnderecoDesativar(CodigoEnd);
                    return RedirectToAction("endereco", "menu");
                }
                return RedirectToAction("index", "home");
            }
            catch
            {
                return RedirectToAction("index", "home");
            }
        }

        public IActionResult MeusDados()
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View();
        }

        public IActionResult SalvarSemSenha(CadastroLogin obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));

            UsuarioDB Usu = new UsuarioDB();

            if (!String.IsNullOrWhiteSpace(obj.JsonLTEDR))
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };

                obj.tb_endereco = JsonConvert.DeserializeObject<List<tb_endereco>>(obj.JsonLTEDR, settings);
            }

            if (Usu.UpDateDadosSemSenhaMenu(obj, cod))
            {
                ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Dados atualizado com sucesso!</div>";
            }
            else
            {
                ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar dados!</div>";
            }
            return View("AtualizaCadastro");
        }

        public IActionResult SalvarEnd(CadastroLogin obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));

            UsuarioDB Usu = new UsuarioDB();

            if (!String.IsNullOrWhiteSpace(obj.JsonLTEDR))
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };

                obj.tb_endereco = JsonConvert.DeserializeObject<List<tb_endereco>>(obj.JsonLTEDR, settings);
            }

            if (Usu.ADDEnd(obj, cod))
            {
                ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Endereço inserido com sucesso!</div>";
            }
            else
            {
                ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir endereço!</div>";
            }
            return View("AddEndereco");
        }


        public IActionResult AtualizaCadastro()
        {
            ViewData["Valida"] = "";

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }
    }
}
