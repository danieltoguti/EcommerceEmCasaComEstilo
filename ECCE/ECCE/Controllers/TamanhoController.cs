using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Data;
using ECCE.Models;
using ECCE.Classes;
using Microsoft.AspNetCore.Http;

namespace ECCE.Controllers
{
    public class TamanhoController : Controller
    {

        private readonly IHttpContextAccessor _hCont;

        public TamanhoController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }
        public IActionResult Index()
        {
            TamanhoDB Cor = new TamanhoDB();
            var MLista = Cor.GetAllTamanho();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View(MLista);
        }

        public IActionResult CadastroTamanho()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult Excluir(int CodigoTamanho)
        {
            TamanhoDB Tam = new TamanhoDB();
            Tam.ExcluirDados(CodigoTamanho);
            return RedirectToAction("index", "Tamanho");
        }

        public IActionResult Editar(int CodigoTamanho, string Descricao)
        {
            var model = new tb_tamanho();
            model.CodigoTamanho = CodigoTamanho;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroTamanho", model);
        }

        public IActionResult Salvar(tb_tamanho obj)
        {
            string smgvalida = Validar(obj);
            if(smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroTamanho");
            }

            TamanhoDB Tamanho = new TamanhoDB();

            if(obj.CodigoTamanho == 0)
            {
                if (Tamanho.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Tamanho inserido com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Tamanho!</div>";
                }
            }
            else
            {
                if (Tamanho.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Tamanho atualizado com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Tamanho!</div>";
                }
            }
            return View("cadastrotamanho");
        }

        public string Validar(tb_tamanho obj)
        {
            TamanhoDB Tamanho = new TamanhoDB();
            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o Tamanho</div>";
            }
            if (Tamanho.ValidaTamanho(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Tamanho já existente!</div>";
            }
            return "";
        }




    }
}
