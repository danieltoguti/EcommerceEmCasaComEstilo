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
    public class CorController : Controller
    {
        private readonly IHttpContextAccessor _hCont;

        public CorController(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
        }

        public IActionResult Index()
        {
            CorDB Cor = new CorDB();
            var MLista = Cor.GetAllCor();

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);


            return View(MLista);
        }

        public IActionResult CadastroCor()
        {
            ViewData["Valida"] = "";

            ViewData["NomeLogin"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            ViewData["Tipo"] = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Tipo);

            return View();
        }

        public IActionResult Excluir(int codigocor)
        {
            CorDB Cor = new CorDB();
            Cor.ExcluirDados(codigocor);
            return RedirectToAction("index", "cor");
        }

        public IActionResult Editar(int CodigoCor, string Descricao)
        {
            var model = new tb_cor();
            model.CodigoCor = CodigoCor;
            model.Descricao = Descricao;
            ViewData["Valida"] = "";
            return View("CadastroCor", model);
        }

        public IActionResult Salvar(tb_cor obj)
        {
            string smgvalida = Validar(obj);
            if(smgvalida != "")
            {
                ViewData["Valida"] = smgvalida;
                return View("CadastroCor");
            }

            CorDB Cor = new CorDB();

            if(obj.CodigoCor == 0)
            {
                if (Cor.InserirDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cor inserida com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao inserir Cor!</div>";
                }
            }
            else
            {
                if (Cor.UpDateDados(obj))
                {
                    ViewData["Valida"] = "<div class='alert alert-success text-center' role='alert'>Cor atualizada com sucesso!</div>";
                }
                else
                {
                    ViewData["Valida"] = "<div class='alert alert-danger text-center' role='alert'>Erro ao atualizar Cor!</div>";
                }
            }
            return View("cadastrocor");
        }

        public string Validar(tb_cor obj)
        {
            CorDB Cor = new CorDB();
            if (String.IsNullOrEmpty(obj.Descricao))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Digite o nome da cor</div>";
            }
            if (Cor.ValidaCor(obj))
            {
                return "<div class='alert alert-warning text-center' role='alert'>Cor já existente!</div>";
            }
            return "";
        }




    }
}
