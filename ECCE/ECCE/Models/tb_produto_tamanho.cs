using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class produtotamanhoModel : tb_produto_tamanho
    {
        public string Descricao { get; set; }
    }
    public class tb_produto_tamanho
    {
        public int CodigoTamanho { get; set; }
        public int CodigoProduto { get; set; }
    }

}
