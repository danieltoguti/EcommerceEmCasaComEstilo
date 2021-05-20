using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class tb_venda
    {
        public int CodigoVenda { get; set; }
        public int CodigoLogin { get; set; }
        public int CodigoEndereco { get; set; }
        public double ValorFinal { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Status { get; set; }
    }
}
