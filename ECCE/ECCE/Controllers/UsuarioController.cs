using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using ECCE.Classes;

namespace ECCE.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        public UsuarioController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }
        public IActionResult Index()
        {
            UsuarioDB Usuario = new UsuarioDB();
            var MLista = Usuario.GetAllFuncionario();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }

        public IActionResult Colaborador()
        {
            UsuarioDB Usuario = new UsuarioDB();
            var MLista = Usuario.GetAllFuncionario();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }

        public IActionResult Cliente()
        {
            UsuarioDB Usuario = new UsuarioDB();
            var MLista = Usuario.GetAllCliente();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }


        public IActionResult CadastroCliente()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            var _Carrinho = new CarrinhoController(_hCont);
            var RespCar = _Carrinho.GetAllDB();
            ViewData["TotalCarrinho"] = (RespCar != null) ? RespCar.Sum(c => c.Quantidade) : 0;

            return View();
        }

        public IActionResult AtualizaCadastroCliente()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }
        public IActionResult AtualizaCadastroColcaborador()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult AtualizaSenhaCliente()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult AtualizaSenhaColaborador()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult MeusDados()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult EditarSemSenhaColaborador(int CodigoLogin)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            UsuarioDB Usuario = new UsuarioDB();
            var model = Usuario.GetUsuario(CodigoLogin);
            model.JsonLTEDR = JsonConvert.SerializeObject(model.tb_endereco);

            ViewData["Valida"] = "";
            return View("AtualizaCadastroColaborador", model);
        }        
        
        public IActionResult EditarSemSenhaCliente(int CodigoLogin)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            UsuarioDB Usuario = new UsuarioDB();
            var model = Usuario.GetUsuario(CodigoLogin);
            model.JsonLTEDR = JsonConvert.SerializeObject(model.tb_endereco);

            ViewData["Valida"] = "";
            return View("AtualizaCadastroCliente", model);
        }

        public IActionResult EditarSenhaColaborador(int CodigoLogin)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            UsuarioDB Usuario = new UsuarioDB();
            var model = Usuario.GetUsuario(CodigoLogin);

            ViewData["Valida"] = "";
            return View("AtualizarSenhaColaborador", model);
        }
        public IActionResult EditarSenhaCliente(int CodigoLogin)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            UsuarioDB Usuario = new UsuarioDB();
            var model = Usuario.GetUsuario(CodigoLogin);

            ViewData["Valida"] = "";
            return View("AtualizarSenhaCliente", model);
        }

        public IActionResult EditarAdmin(int CodigoLogin)
        {
            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            UsuarioDB Usuario = new UsuarioDB();
            var model = Usuario.GetUsuario(CodigoLogin);
            model.JsonLTEDR = JsonConvert.SerializeObject(model.tb_endereco);
          
            ViewData["Valida"] = "";
            return View("CadastroCliente", model);
        }



        public IActionResult Salvar(CadastroLogin obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            string smgvalida = Validar(obj.tb_login);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroCliente");
            }

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

            if (obj.tb_login.CodigoLogin == 0)
            {

                if (Usu.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cadastro efetuado com sucesso! Faça seu login! ";
                    return  View("CadastroCliente");

                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Registro!</div>";
                    return View("CadastroCliente");
                }
            }
            else
            {
                if (Usu.UpDateDadosUsuario(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Registro atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Registro!</div>";
                }
                return View("CadastroCliente");
            }


        }

            public IActionResult SalvarSemSenhaCliente(CadastroLogin obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            string smgvalida = Validar(obj.tb_login);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("AtualizarSenhaCliente");
            }

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

            if (obj.tb_login.CodigoLogin == 0)
            {

                if (Usu.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cadastro efetuado com sucesso!  ";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Registro!</div>";
                }
                return View("AtualizaCadastroCliente");
            }
            else
            {
                if (Usu.UpDateDadosUsuarioSemSenha(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Registro atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Registro!</div>";
                }
                return View("AtualizaCadastroCliente");
            }
        }

        public IActionResult SalvarSemSenhaColaborador (CadastroLogin obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            string smgvalida = Validar(obj.tb_login);
            if (smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("AtualizarSenhaColaborador");
            }

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

            if (obj.tb_login.CodigoLogin == 0)
            {

                if (Usu.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cadastro efetuado com sucesso!  ";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Registro!</div>";
                }
                return View("AtualizaCadastroColaborador");
            }
            else
            {
                if (Usu.UpDateDadosUsuarioSemSenha(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Registro atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Registro!</div>";
                }
                return View("AtualizaCadastroColaborador");
            }
        }

        public IActionResult SalvarSenha(CadastroLogin obj)
        {

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            UsuarioDB Usu = new UsuarioDB();

                if (Usu.UpDateSenha(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Registro atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Registro!</div>";
                }
                return View("AtualizarSenha");

        }

        public string Validar(tb_login obj)
        {

            UsuarioDB Usu = new UsuarioDB();

            if (String.IsNullOrEmpty(obj.Nome))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome do funcionario!</div>";
            }

            if (obj.CodigoLogin == 0)
            {
                if (Usu.ValidarEmail(obj))
                {
                    return "<div class='alert alert-warning text-center' role='alert'>Email já cadastrado com um usuário!</div>";
                }
            }

            return "";
        }




    }
}
