using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;
using Microsoft.AspNetCore.Http;
using ECCE.Classes;
using Microsoft.AspNetCore.Authorization;

namespace ECCE.Controllers
{
    public class GeneroController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public GeneroController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        [Authorize(Roles = "A")]
        public IActionResult Index()
        {
            GeneroDB Genero = new GeneroDB();
            var MLista = Genero.GetAllGenero();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }


        [Authorize(Roles = "A")]
        public IActionResult CadastroGenero()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        [Authorize(Roles = "A")]
        public IActionResult Excluir(int CodigoGenero)
        {
            GeneroDB Genero = new GeneroDB();
            Genero.ExcluirDados(CodigoGenero);
            return RedirectToAction("index", "genero");
        }

        [Authorize(Roles = "A")]
        public IActionResult Editar(int CodigoGenero, string Descricao)
        {
            var model = new tb_genero();
            model.CodigoGenero = CodigoGenero;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroGenero", model);
        }

        [Authorize(Roles = "A")]
        public IActionResult Salvar(tb_genero obj)
        {
            string smgvalida = Validar(obj);
            if(smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroGenero");
            }

            GeneroDB Genero = new GeneroDB();

            if(obj.CodigoGenero == 0)
            {
                if (Genero.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Genero inserido com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Genero!</div>";
                }
            }
            else
            {
                if (Genero.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Genero atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Genero!</div>";
                }
            }
            return View("cadastrogenero");
        }

        public string Validar(tb_genero obj)
        {
            GeneroDB Genero = new GeneroDB();
            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o Genero</div>";
            }
            if (Genero.ValidaGenero(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Cor já existente!</div>";
            }
            return "";
        }




    }
}
