using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class CarrinhoModel
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public int Quantidade { get; set; }
        public string Cor { get; set; }
        public string Tamanho { get; set; }
        public double Preco { get; set; }
        public string Foto { get; set; }
    }
}
