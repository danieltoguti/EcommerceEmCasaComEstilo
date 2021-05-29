using ECCE.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Classes;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ECCE.Data
{
    public class RelatorioDB
    {

        public Colaborador Colaboradores()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT COUNT(*) AS Colaboradores FROM tb_login WHERE tipo='A';";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrColaborador = cmd.ExecuteReader();

                DrColaborador.Read();

                var colaborador = new Colaborador()
                {
                    TotalColaborador = Convert.ToInt32(DrColaborador["Colaboradores"])
                };

                var model = new Colaborador();
                model.TotalColaborador = Convert.ToInt32(colaborador.TotalColaborador);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Cliente Clientes()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT COUNT(*) AS Clientes FROM tb_login WHERE tipo='C'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrCliente = cmd.ExecuteReader();

                DrCliente.Read();

                var cliente = new Cliente()
                {
                    TotalCliente = Convert.ToInt32(DrCliente["Clientes"])
                };

                var model = new Cliente();
                model.TotalCliente = Convert.ToInt32(cliente.TotalCliente);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Produto Produtos()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT COUNT(DISTINCT nome) as Produtos FROM tb_produto WHERE Ativo='Sim'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrProduto = cmd.ExecuteReader();

                DrProduto.Read();

                var produto = new Produto()
                {
                    TotalProduto = Convert.ToInt32(DrProduto["Produtos"])
                };

                var model = new Produto();
                model.TotalProduto = Convert.ToInt32(produto.TotalProduto);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Produto QuantidadeProdutos()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT SUM(Quantidade) AS TotalProdutos FROM  tb_produto WHERE Ativo='Sim'";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrProduto = cmd.ExecuteReader();

                DrProduto.Read();

                var produto = new Produto()
                {
                    QuantidadeTotal = Convert.ToInt32(DrProduto["TotalProdutos"])
                };

                var model = new Produto();
                model.QuantidadeTotal = Convert.ToInt32(produto.QuantidadeTotal);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Vendas Vendas()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT COUNT(*) AS Vendas FROM  tb_venda where DataRegistro between date_sub(now(), INTERVAL 1 WEEK) and NOW(); ";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    TotalVenda = Convert.ToInt32(DrVenda["Vendas"])
                };

                var model = new Vendas();
                model.TotalVenda = Convert.ToInt32(venda.TotalVenda);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Vendas VendaValor()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT SUM(ValorFinal) AS Valor FROM tb_venda where DataRegistro between date_sub(now(), INTERVAL 1 WEEK) and NOW()";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    VendaValor = Convert.ToDouble(DrVenda["Valor"])
                };

                var model = new Vendas();
                model.VendaValor = Convert.ToDouble(venda.VendaValor);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Vendas MediaVendas()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                sSQL = "SELECT(SUM(ValorFinal) / COUNT(*)) AS ValorFinal FROM tb_venda";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    MedidaVendas = Convert.ToDouble(DrVenda["ValorFinal"])
                };

                var model = new Vendas();
                model.MedidaVendas = Convert.ToDouble(venda.MedidaVendas);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public Vendas MaiorVendas()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                sSQL = "SELECT MAX(ValorFinal) AS MaiorVenda FROM tb_venda";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var DrVenda = cmd.ExecuteReader();

                DrVenda.Read();

                var venda = new Vendas()
                {
                    MaiorVenda = Convert.ToDouble(DrVenda["MaiorVenda"])
                };

                var model = new Vendas();
                model.MaiorVenda = Convert.ToDouble(venda.MaiorVenda);

                return model;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

    }


}

