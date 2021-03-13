using ECCE.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Classes;

namespace ECCE.Data
{
    public class FuncionarioFuncaoDB
    {
        public bool InserirDados(tb_funcionario_funcao obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_funcionario_funcao(Descricao) values (@descricao)";
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);

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

        public bool UpDateDados(tb_funcionario_funcao obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_funcionario_funcao set descricao=@descricao where codigofuncao=@codigofuncao";
                    cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                    cmd.Parameters.AddWithValue("@codigofuncao", obj.CodigoFuncao);

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

        public bool ExcluirDados(int Codigo)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "delete from tb_funcionario_funcao where CodigoFuncao=@CodigoFuncao";
                    cmd.Parameters.AddWithValue("@CodigoFuncao", Codigo);

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
        public bool ValidaFuncao(tb_funcionario_funcao obj)

        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_funcionario_funcao where descricao=@descricao";
                cmd.Parameters.AddWithValue("@descricao", obj.Descricao);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();
                return Dr.HasRows;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public List<tb_funcionario_funcao> GetAllFuncao()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_funcionario_funcao order by descricao";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_funcionario_funcao>();

                while (Dr.Read())
                {
                    var item = new tb_funcionario_funcao
                    {
                        CodigoFuncao = Convert.ToInt32(Dr["Codigofuncao"]),
                        Descricao = Dr["Descricao"].ToString()
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
    }


}

