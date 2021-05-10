using ECCE.Classes;
using ECCE.Controllers;
using ECCE.Models;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECCE.Data
{
    public class FinalizarPedidoDB
    {
        public string scnx;

        private readonly IHttpContextAccessor _hCont;

        public FinalizarPedidoDB(IHttpContextAccessor httpContextAccessor)
        {
            _hCont = httpContextAccessor;
            scnx = CConexao.Get_StringConexao();
        }


        public bool FinalizarPedido(FinalizarPedidoVM obj)
        {
            CarrinhoController car = new CarrinhoController(_hCont);
            var Carrinho = car.GetAllDB();

            var CodigoLogin = Convert.ToInt32(CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.CodigoLogin));
            var Nome = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Nome);
            var Email = CMetodos_Autenticacao.GET_DadosUser(_hCont, CMetodos_Autenticacao.eDadosUser.Email);
            var CodigoEndereco = GetCodigoEndereco(CodigoLogin, obj.CEP);
            string Sql = "";

            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection cn = new MySqlConnection(scnx);
            cn.Open();
            cmd.Connection = cn;

            Sql = "insert into tb_venda(CodigoLogin,CodigoEndereco,ValorFinal,DataRegistro,Status) values";
            Sql += "(@CodigoLogin,@CodigoEndereco,@ValorFinal,now(),0)";
            cmd.Parameters.AddWithValue("@CodigoLogin", CodigoLogin);
            cmd.Parameters.AddWithValue("@CodigoEndereco", CodigoEndereco);
            cmd.Parameters.AddWithValue("@ValorFinal", obj.TotalPedido);
            cmd.CommandText = Sql;

            var RespPedido = cmd.ExecuteNonQuery();

            if (RespPedido == 1)
            {
                var CodigoVenda = GetPedidoVenda(CodigoLogin);

                foreach (var item in Carrinho)
                {
                    cmd.Parameters.Clear();
                    Sql = "insert into tb_venda_itens(CodigoVenda, CodigoProduto, Valor, Quantidade) values";
                    Sql += "(@CodigoVenda,@CodigoProduto,@Valor,@Quantidade);";

                    //Retira Estoque;

                    Sql += "update tb_produto set Quantidade=Quantidade-@Quantidade where CodigoProduto=@CodigoProduto;";

                    cmd.Parameters.AddWithValue("@CodigoVenda", CodigoVenda);
                    cmd.Parameters.AddWithValue("@CodigoProduto", item.CodigoProduto);
                    cmd.Parameters.AddWithValue("@Valor", item.Preco);
                    cmd.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                    cmd.CommandText = Sql;
                    cmd.ExecuteNonQuery();

                }

                var Car = new CarrinhoController(_hCont);
                Car.RemoveAll();

                return true;
            }

            return false;
        }


        public int GetCodigoEndereco(int CodigoLogin, string CEP)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT CodigoEndereco FROM tb_endereco WHERE CodigoLogin=@CodigoLogin AND CEP=@CEP";
                cmd.Parameters.AddWithValue("CodigoLogin", CodigoLogin);
                cmd.Parameters.AddWithValue("CEP", CEP);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                Dr.Read();

                if (Dr.HasRows)
                {
                    return Convert.ToInt32(Dr["CodigoEndereco"]);
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception e)
            {
                string msg = e.Message;
                return 0;
            }
        }


        public int GetPedidoVenda(int CodigoLogin)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT CodigoVenda FROM tb_venda WHERE Codigologin=@CodigoLogin order by CodigoVenda desc LIMIT 1";
                cmd.Parameters.AddWithValue("CodigoLogin", CodigoLogin);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                Dr.Read();

                if (Dr.HasRows)
                {
                    return Convert.ToInt32(Dr["CodigoVenda"]);
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception e)
            {
                string msg = e.Message;
                return 0;
            }
        }


    }
}
