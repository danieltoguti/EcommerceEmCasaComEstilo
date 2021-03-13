using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class produtocorModel : tb_produto_cor
    {
        public string Descricao { get; set; }
    }
    public class tb_produto_cor
    {
        public int CodigoCor { get; set; }
        public int CodigoProduto { get; set; }
    }
}
