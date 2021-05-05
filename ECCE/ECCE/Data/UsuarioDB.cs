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
    public class UsuarioDB
    {
        public bool InserirDados(CadastroLogin obj)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "insert into tb_login(nome, email, telefone, cpf_cnpj, senha, tipo, datacadastro, ativo) values " +
                    "(@nome, @email, @telefone, @cpf_cnpj, MD5(@senha), 'C', Now(), 1)";

                cmd.Parameters.AddWithValue("@nome", obj.tb_login.Nome);
                cmd.Parameters.AddWithValue("@email", obj.tb_login.Email);
                cmd.Parameters.AddWithValue("@telefone", obj.tb_login.Telefone);
                cmd.Parameters.AddWithValue("@cpf_cnpj", obj.tb_login.CPF_CNPJ);
                cmd.Parameters.AddWithValue("@senha", obj.tb_login.Senha);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                ADDEndereco(obj);
                return true;

            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }
        public bool ADDEndereco(CadastroLogin obj)
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
                    sSQL = "insert into tb_endereco (CodigoLogin, Descricao, CEP, Endereco, Numero,  Bairro, Cidade, UF)";
                    sSQL += "values(@CodigoLogin, @Descricao, @CEP, @Endereco, @Numero,  @Bairro, @Cidade, @UF)";
                    cmd.Parameters.AddWithValue("@CodigoLogin", CodigoLogin);
                    cmd.Parameters.AddWithValue("@Descricao", item.Descricao);
                    cmd.Parameters.AddWithValue("@CEP", item.Cep);
                    cmd.Parameters.AddWithValue("@Endereco", item.Endereco);
                    cmd.Parameters.AddWithValue("@Numero", item.Numero);

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
        public bool UpDateDadosUsuario(CadastroLogin obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_login set nome=@nome, email=@email, telefone=@telefone, cpf_cnpj=@cpf_cnpj, " +
                        "senha=MD5(@senha), tipo=@tipo, Ativo=@ativo where CodigoLogin=@codigologin";
                    cmd.Parameters.AddWithValue("@nome", obj.tb_login.Nome);
                    cmd.Parameters.AddWithValue("@email", obj.tb_login.Email);
                    cmd.Parameters.AddWithValue("@telefone", obj.tb_login.Telefone);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", obj.tb_login.CPF_CNPJ);
                    cmd.Parameters.AddWithValue("@senha", obj.tb_login.Senha);
                    cmd.Parameters.AddWithValue("@tipo", obj.tb_login.Tipo);
                    cmd.Parameters.AddWithValue("@Ativo", obj.tb_login.Ativo);
                    cmd.Parameters.AddWithValue("@codigologin", obj.tb_login.CodigoLogin);


                    cmd.CommandText = sSQL;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    ADDEndereco(obj);
                    return true;
                }
                catch (Exception e)
                {
                    string msg = e.Message;
                    return false;
                }
            }

        }


        public bool UpDateTipoUsuario(tb_login obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "UPDATE tb_login SET Tipo=@tipo where CodigoLogin=@codigologin";
                    cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
                    cmd.Parameters.AddWithValue("@codigologin", obj.CodigoLogin);


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


        public bool ValidarComoFuncionario(int id)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_login Set tipo='A' where CodigoLogin=@id";
                    cmd.Parameters.AddWithValue("@id", id);

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

        public bool ValidarEmail(tb_login obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where email=@email";
                cmd.Parameters.AddWithValue("@email", obj.Email);

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

        public CadastroLogin GetUsuario(int CodigoLogin)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where CodigoLogin=@codigoLogin";
                cmd.Parameters.AddWithValue("@CodigoLogin", CodigoLogin);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                Dr.Read();

                var Usuario = new tb_login()
                {
                    CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"]),
                    Nome = Dr["Nome"].ToString(),
                    Email = Dr["Email"].ToString(),
                    Telefone = Dr["Telefone"].ToString(),
                    CPF_CNPJ = Dr["CPF_CNPJ"].ToString(),
                    Senha = Dr["Senha"].ToString(),
                    Tipo = Dr["Tipo"].ToString(),
                    Ativo = Dr["Ativo"].ToString(),

                };

                Dr.Dispose();

                //Carrega Endereços             
                sSQL = "select * from tb_endereco where CodigoLogin=@CodigoLogin";
                cmd.CommandText = sSQL;
                var DrEndereco = cmd.ExecuteReader();

                var tb_endereco = new List<tb_endereco>();

                while (DrEndereco.Read())
                {
                    tb_endereco.Add(new tb_endereco()
                    {
                        CodigoEndereco = Convert.ToInt32(DrEndereco["CodigoEndereco"]),
                        CodigoLogin = Convert.ToInt32(DrEndereco["CodigoLogin"]),
                        Descricao = DrEndereco["Descricao"].ToString(),
                        Cep = DrEndereco["CEP"].ToString(),
                        Endereco = DrEndereco["Endereco"].ToString(),
                        Numero = DrEndereco["Numero"].ToString(),
                        Bairro = DrEndereco["Bairro"].ToString(),
                        Cidade = DrEndereco["Cidade"].ToString(),
                        UF = DrEndereco["UF"].ToString(),
                    });
                }

                var model = new CadastroLogin();
                model.tb_login = Usuario;
                model.tb_endereco = tb_endereco;

                return model;
            }


            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<tb_login> GetAllFuncionario()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where tipo='F' OR tipo='A' order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_login>();

                while (Dr.Read())
                {
                    var item = new tb_login
                    {
                        CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"]),
                        Nome = Dr["Nome"].ToString(),
                        Email = Dr["Email"].ToString(),
                        Telefone = Dr["Telefone"].ToString(),
                        Tipo = Dr["Tipo"].ToString()
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

        public List<tb_login> GetAllCliente()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where tipo='C' order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_login>();

                while (Dr.Read())
                {
                    var item = new tb_login
                    {
                        CodigoLogin = Convert.ToInt32(Dr["CodigoLogin"]),
                        Nome = Dr["Nome"].ToString(),
                        Email = Dr["Email"].ToString(),
                        Telefone = Dr["Telefone"].ToString()
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

