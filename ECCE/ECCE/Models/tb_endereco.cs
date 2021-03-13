using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{    
    public class tb_endereco
    {
        [Key]
        public int CodigoEndereco { get; set; }
        [Key]
        public int CodigoLogin { get; set; }

        [Display(Name ="Descrição", Prompt ="Casa, Trabalho, Entrega, etc.")]
        public string Descricao { get; set; }

        [Display(Name = "* CEP", Prompt = "")]
        public string Cep { get; set; }

        [Display(Name = "* Rua, Av, Rod", Prompt = "")]
        public string Endereco { get; set; }

        [Display(Name = "* Número", Prompt = "")]
        public string Numero { get; set; }

        [Display(Name = "Complemento", Prompt = "")]
        public string Complemento{ get; set; }

        [Display(Name = "* Bairro", Prompt = "")]
        public string Bairro { get; set; }

        [Display(Name = "* Cidade", Prompt ="")]
        public string Cidade { get; set; }

        [Display(Name = "* UF", Prompt = "")]
        public string UF { get; set; }
    }

}
