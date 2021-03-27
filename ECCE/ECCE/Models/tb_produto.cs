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
        public string JsonLTCategoria { get; set; }
        public string JsonLTCor { get; set; }
        public string JsonLTFoto { get; set; }
        public string JsonLTGenero { get; set; }
        public string JsonLTTamanho { get; set; }
    }

    public class ProdutoView
    {
        public tb_produto tb_produto { get; set; }
        public List<produtocorModel> produtocorModel { get; set; }
        public List<produtogeneroModel> produtogeneroModel { get; set; }
        public List<produtotamanhoModel> produtotamanhoModel { get; set; }
        public List<produtocategoriaModel> produtocategoriaModel { get; set; }
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

        [Display(Name = "Cógigo", Prompt = "")]
        public string CodigoInterno { get; set; }

        [Display(Name = "Nome", Prompt = "")]
        public string Nome { get; set; }

        [Display(Name = "Descrição", Prompt = "")]
        public string Descricao { get; set; }

        [Display(Name = "Valor", Prompt = "")]
        public double Valor { get; set; }

        [Display(Name = "Fotos", Prompt = "")]
        public double Foto { get; set; }

        [Display(Name = "Data Registro", Prompt = "")]
        public DateTime DataRegistro { get; set; }

        [Display(Name = "Peso", Prompt = "")]
        public double Peso { get; set; }

        [Display(Name = "Status", Prompt = "Digite 1 para ativo e 0 para inativo")]
        public double Ativo { get; set; }
    }
}
