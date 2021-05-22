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
            FinalizarPedidoDB Pedido = new FinalizarPedidoDB();
            var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
            var MLista = Pedido.ListarPedidosCliente(cod);

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            /*=============*/
            
            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;
            
            /*============*/

            return View(MLista);
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

        public IActionResult EditaSSenha()
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            var cod = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));

            UsuarioDB Usuario = new UsuarioDB();
            var model = Usuario.GetUsuario(cod);
            model.JsonLTEDR = JsonConvert.SerializeObject(model.tb_endereco);

            ViewData["Valida"] = "";
            return View("AtualizaCadastro", model);
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

        public IActionResult AddEndereco()
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
