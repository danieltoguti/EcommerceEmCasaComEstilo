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
    public class EnderecoDB
    {
        public bool InserirEndereco(CadastroLogin obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();
                cmd.Connection = cn;

                var CodigoLogin = obj.tb_login.CodigoLogin;
                if (obj.tb_login.CodigoLogin == 0)
                {
                    sSQL = "select CodigoLogin from tb_login order by Codigologin desc limit 1 ";
                    cmd.CommandText = sSQL;
                    var Dr = cmd.ExecuteReader();
                    Dr.Read();
                    CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"].ToString());
                    Dr.Dispose();
                }

                //Deletando Registros antes do insert caso for update
                cmd.Parameters.Clear();
                sSQL = "delete from tb_endereco where CodigoLogin=" + CodigoLogin;
                cmd.CommandText = sSQL;
                cmd.ExecuteNonQuery();


                foreach (var item in obj.tb_endereco)
                {
                    cmd.Parameters.Clear();
                    sSQL = "insert into tb_endereco (CodigoLogin, Descricao, CEP, Endereco, Numero, Complemento, Bairro, Cidade, UF)";
                    sSQL += "values(@CodigoLogin, @Descricao, @CEP, @Endereco, @Numero, @Complemento, @Bairro, @Cidade, @UF)";
                    cmd.Parameters.AddWithValue("@CodigoLogin", CodigoLogin);
                    cmd.Parameters.AddWithValue("@Descricao", item.Descricao);
                    cmd.Parameters.AddWithValue("@CEP", item.Cep);
                    cmd.Parameters.AddWithValue("@Endereco", item.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", item.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", item.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", item.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", item.Cidade);
                    cmd.Parameters.AddWithValue("UF", item.UF);
                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpDateEndereco(tb_endereco obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_endereco set Descricao=@decricao, CEP=@cep, Endereco=@endereco, Numero=@numero, " +
                        "Complemento=@complemento, Bairro=@bairro, Cidade=@cidade, UF=@uf";
                    cmd.Parameters.AddWithValue("@Descricao", obj.Descricao);
                    cmd.Parameters.AddWithValue("@CEP", obj.Cep);
                    cmd.Parameters.AddWithValue("@Endereco", obj.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", obj.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", obj.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", obj.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
                    cmd.Parameters.AddWithValue("UF", obj.UF);


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

        public bool ExcluirEndereco(int Codigo)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "delete from tb_endereco  where codigologin=@codigologin";
                    cmd.Parameters.AddWithValue("@codigologin", Codigo);

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

