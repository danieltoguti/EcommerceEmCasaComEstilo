using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;
using Microsoft.AspNetCore.Http;
using ECCE.Classes;

namespace ECCE.Controllers
{
    public class EnderecoController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        public EnderecoController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        public IActionResult CadastroEndereco()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult Editar(int Codigo)
        {
            UsuarioDB Usu = new UsuarioDB();
            var model = Usu.GetAllCliente();

            ViewData["Valida"] = "";
            return View("index", model);
        }

        public IActionResult SalvarEndereco(CadastroLogin obj)
        {
            EnderecoDB Endereco = new EnderecoDB();

            if (obj.tb_Endereco.CodigoEndereco == 0)
            {

                if (Endereco.InserirEndereco(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Endereco inserido(a) com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Endereco!</div>";
                }
            }
            else
            {
                if (Endereco.UpDateEndereco(obj.tb_Endereco))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Endereco atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Endereco!</div>";
                }
            }

            return View("cadastrocliente");
        }





    }
}
