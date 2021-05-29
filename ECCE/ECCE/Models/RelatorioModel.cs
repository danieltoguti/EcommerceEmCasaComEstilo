using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Models
{
    public class RelatorioModel
    {
        public Cliente Clientes { get; set; }
        public Colaborador Colaboradores { get; set; }
        public Vendas Vendas { get; set; }
        public Produto Produtos { get; set; }

    }

    public class Produto
    {
        public int TotalProduto { get; set; }
        public int QuantidadeTotal { get; set; }
    }

    public class Colaborador
    {
        public int TotalColaborador { get; set; }
    }

    public class Cliente
    {
        public int TotalCliente { get; set; }
    }

    public class Vendas
    {
        public int TotalVenda { get; set; }
        public double VendaValor { get; set; }
        public double MedidaVendas { get; set; }
        public double MaiorVenda { get; set; }
    }
}
