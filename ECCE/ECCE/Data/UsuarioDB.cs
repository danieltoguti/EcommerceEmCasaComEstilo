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
                    //cmd.Parameters.AddWithValue("@Complemento", item.Complemento);
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

                    sSQL = "update tb_login set nome=@nome, email=@email, telefone=@telefone, cpf_cnpj@cpf_cnpj, " +
                        "senha@senha where CodigoLogin=@codigologin";
                    cmd.Parameters.AddWithValue("@nome", obj.tb_login.Nome);
                    cmd.Parameters.AddWithValue("@email", obj.tb_login.Email);
                    cmd.Parameters.AddWithValue("@telefone", obj.tb_login.Telefone);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", obj.tb_login.CPF_CNPJ);
                    cmd.Parameters.AddWithValue("@senha", obj.tb_login.Senha);
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

        public bool ValidarNome(tb_login obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where nome=@nome";
                cmd.Parameters.AddWithValue("@nome", obj.Nome);

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

        public bool UpDateDadosAdmin(tb_login obj)
        {
            {
                try
                {
                    string sSQL = "";
                    MySqlCommand cmd = new MySqlCommand();
                    MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                    cn.Open();

                    sSQL = "update tb_login set nome=@nome, email=@email, telefone=@telefone, cpf_cnpj@cpf_cnpj, " +
                        "senha@senha, tipo=@tipo, ativo=@ativo, codigofuncao=@codigofuncao";
                    cmd.Parameters.AddWithValue("@nome", obj.Nome);
                    cmd.Parameters.AddWithValue("@email", obj.Email);
                    cmd.Parameters.AddWithValue("@cpf_cnpj", obj.CPF_CNPJ);
                    cmd.Parameters.AddWithValue("@senha", obj.Senha);
                    cmd.Parameters.AddWithValue("@tipo", obj.Tipo);
                    cmd.Parameters.AddWithValue("@ativo", obj.Ativo);
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

                    sSQL = "delete from tb_login  where codigologin=@codigologin";
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
        public bool Validalogin(tb_login obj)

        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where nome=@nome";
                cmd.Parameters.AddWithValue("@nome", obj.Nome);

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

        public List<tb_login> GetAll()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login order by nome";

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
                        CodigoFuncao = Dr["CodigoFuncao"].ToString()

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

        public List<tb_login> GetAllFuncionario()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where tipo='F' order by nome";

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

        public List<tb_login> GetDadosUsuario(int Codigo)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_login where codigologin=@codigologin";
                cmd.Parameters.AddWithValue("@codigologin", Codigo);

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
                        CPF_CNPJ = Dr["CPF_CNPJ"].ToString(),
                        Senha = Dr["Senha"].ToString(),
                        
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

