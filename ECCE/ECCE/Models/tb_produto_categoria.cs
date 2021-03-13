using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{


    public class produtocategoriaModel: tb_produto_categoria
    {
        public string Descricao { get; set; }
    }
    public class tb_produto_categoria
    {
        public int CodigoCategoria { get; set; }
        public int CodigoProduto { get; set; }
    }
}
