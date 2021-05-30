using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ECCE.Models
{


    public class ProdutoModel
    {
        public tb_produto tb_produto { get; set; }        
        public string JsonLTFoto { get; set; }
        public string JsonLTGenero { get; set; }
    }

    public class ProdutoView
    {
        public tb_produto tb_produto { get; set; }
        public List<produtogeneroModel> produtogeneroModel { get; set; }
        public List<produtofotoModel> produtofotoModel { get; set; }


    }

    public class ProdutoVWList {
        public tb_produto tb_produto { get; set; }
        public string Foto { get; set; }
    }


    public class tb_produto
    {
        [Key]
        public int CodigoProduto { get; set; }

        [Display(Name = "Código", Prompt = "")]
        public string CodigoInterno { get; set; }

        [Display(Name = "Nome", Prompt = "")]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Prompt = "")]
        public string Descricao { get; set; }

        [Display(Name = "Valor", Prompt = "")]
        public decimal Valor { get; set; }

        [Display(Name = "Fotos", Prompt = "")]
        public string Foto { get; set; }

        [Display(Name = "Data Registro", Prompt = "")]
        public DateTime DataRegistro { get; set; }

        [Display(Name = "Peso", Prompt = "")]
        public double Peso { get; set; }

        [Display(Name = "Quantidade", Prompt = "")]
        public int Quantidade { get; set; }

        [Display(Name = "Ativo", Prompt = "Sim / Não")]
        public string Ativo { get; set; }

        [Display(Name = "Tamanho", Prompt = "")]
        public string Tamanho { get; set; }
    }
}
