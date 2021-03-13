using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class produtofotoModel : tb_produto_foto
    {
        public string Descricao { get; set; }
    }
    public class tb_produto_foto
    {
        public int CodigoFoto { get; set; }
        public int CodigoProduto { get; set; }        
        public string Caminho { get; set; }
    }
}
