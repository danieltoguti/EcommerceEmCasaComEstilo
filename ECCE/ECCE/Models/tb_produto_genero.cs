using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class produtogeneroModel : tb_produto_genero 
    {
        public string Descricao { get; set; }
    }
    public class tb_produto_genero
    {
        public int CodigoGenero { get; set; }
        public int CodigoProduto { get; set; }
    }
}
