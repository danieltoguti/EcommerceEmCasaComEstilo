using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{

    public class FinalizarPedidoVM
    {
        public string CEP { get; set; }
        public double TotalPedido { get; set; }

        public static implicit operator FinalizarPedidoVM(ItensVenda v)
        {
            throw new NotImplementedException();
        }
    }

    public class TodosPedidos
    {
        public int CodigoVenda { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
    }

    public class ItensVenda
    {
        public int CodigoVenda { get; set; }
        public string CodigoInterno { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
