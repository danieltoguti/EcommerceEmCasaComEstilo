using ECCE.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECCE.Classes;

namespace ECCE.Data
{
    public class CorDB
    {
        public bool InserirDados(tb_cor obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_cor(Descricao) values (@descricao)";
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

        public bool UpDateDados(tb_cor obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_cor set descricao=@descricao where codigocor=@codigocor";
                    cmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                    cmd.Parameters.AddWithValue("@codigocor", obj.CodigoCor);

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

                    sSQL = "delete from tb_cor  where codigocor=@codigocor";
                    cmd.Parameters.AddWithValue("@codigocor", Codigo);

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
        public bool ValidaCor(tb_cor obj)

        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_cor where descricao=@descricao";
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

        public List<tb_cor> GetAllCor()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_cor order by descricao";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_cor>();

                while (Dr.Read())
                {
                    var item = new tb_cor
                    {
                        CodigoCor = Convert.ToInt32(Dr["CodigoCor"]),
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

