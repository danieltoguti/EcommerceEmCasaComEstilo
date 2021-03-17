using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{

    public class tb_venda_itens
    {
        public int CodigoVendaItens { get; set; }
        public int CodigoVenda { get; set; }
        public int CodigoProduto { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

    }

}

