using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class CadastroLogin
    {
        public tb_login tb_login { get; set; }
        public List<tb_endereco> tb_endereco { get; set; }
        public tb_endereco tb_Endereco { get; set; }
        public string JsonLTEDR { get; set; }
    }

    public class LoginAcesso {
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class tb_login
    {
        public int CodigoLogin { get; set; }

        [Display(Name = "Nome", Prompt = "")]
        public string Nome { get; set; }

        [Display(Name = "Email", Prompt = "")]
        public string Email { get; set; }

        [Display(Name = "Telefone", Prompt = "")]
        public string Telefone { get; set; }

        [Display(Name = "CPF", Prompt = "")]
        public string CPF_CNPJ { get; set; }

        [Display(Name = "Senha", Prompt = "")]
        public string Senha { get; set; }

        [Display(Name = "Tipo", Prompt = "")]
        public string Tipo { get; set; } = "C";

        [Display(Name = "Data de Cadastro", Prompt = "")]
        public string DataCadastro { get; set; }

        [Display(Name = "Ativo", Prompt = "")]
        public string Ativo { get; set; }
    }


}
