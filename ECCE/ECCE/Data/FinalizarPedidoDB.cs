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

        public FinalizarPedidoDB()
        {
        }

        public bool FinalizarPedido(FinalizarPedidoVM obj)
        {
            try
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

                        var Car = new CarrinhoController(_hCont);
                        Car.RemoveAll();

                        return true;
                    }
                }
                else
                {
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                var Car = new CarrinhoController(_hCont);
                Car.RemoveAll();
                return false;
            }
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

        public int GetPedidoStatus(int CodigoVenda)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT status FROM tb_venda WHERE codigovenda=@codigovenda";
                cmd.Parameters.AddWithValue("@codigovenda", CodigoVenda);

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


        public List<TodosPedidos> ListarPedidos()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT v.codigovenda, l.Nome, v.ValorFinal, v.Dataregistro, v.Status FROM tb_venda AS v " +
                    "INNER JOIN tb_login AS l ON v.CodigoLogin = l.CodigoLogin;";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<TodosPedidos>();

                while (Dr.Read())
                {
                    var item = new TodosPedidos
                    {
                        CodigoVenda = Convert.ToInt32(Dr["CodigoVenda"]),
                        Nome = Dr["Nome"].ToString(),
                        Valor = Convert.ToDouble(Dr["ValorFinal"]),
                        Data = Convert.ToDateTime(Dr["DataRegistro"]),
                        Status = Dr["Status"].ToString()
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }


        public List<TodosPedidos> ListarPedidosCliente(int cod)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT v.codigovenda, v.valorfinal, v.dataregistro, v.status FROM tb_venda AS v WHERE v.CodigoLogin=" + cod;

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<TodosPedidos>();

                while (Dr.Read())
                {
                    var item = new TodosPedidos
                    {
                        CodigoVenda = Convert.ToInt32(Dr["CodigoVenda"]),
                        Valor = Convert.ToDouble(Dr["ValorFinal"]),
                        Data = Convert.ToDateTime(Dr["DataRegistro"]),
                        Status = Dr["Status"].ToString(),
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }



        public List<ItensVenda> GetItemVenda(int CodigoVenda)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT v.codigovenda, p.CodigoInterno, p.nome, p.Tamanho, i.quantidade, i.valor, v.DataRegistro FROM tb_venda AS v " +
                                   "INNER JOIN tb_venda_itens AS i ON v.CodigoVenda = i.CodigoVenda " +
                                   "INNER JOIN tb_produto AS p ON p.CodigoProduto = i.CodigoProduto " +
                                   "WHERE v.CodigoVenda=@CodigoVenda; ";
                cmd.Parameters.AddWithValue("@CodigoVenda", CodigoVenda);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<ItensVenda>();

                while (Dr.Read())
                {
                    var item = new ItensVenda
                    {
                        CodigoVenda = Convert.ToInt32(Dr["CodigoVenda"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Tamanho = Dr["Tamanho"].ToString(),
                        Quantidade = Convert.ToInt32(Dr["Quantidade"]),
                        Valor = Convert.ToDouble(Dr["Valor"]),
                        Data = Convert.ToDateTime(Dr["DataRegistro"]),
                    };
                    Lista.Add(item);
                }

                return Lista;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public bool UpDateStatus(tb_venda obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "UPDATE tb_venda SET status=@status WHERE codigovenda=@codigovenda;";
                    cmd.Parameters.AddWithValue("@status", obj.Status);
                    cmd.Parameters.AddWithValue("@codigovenda", obj.CodigoVenda);

                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }

        }


    }
}
