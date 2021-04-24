using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECCE.Classes
{
    public class CMetodos_Autenticacao
    {
        public enum eDadosUser
        {
            CodigoLogin,
            Nome,
            Email,
            Tipo,
        }


        public static async Task<string> LoginValidoAsync(string Email, string Senha, IHttpContextAccessor hcont)
        {

            using (MySqlConnection Cnn = new MySqlConnection(CConexao.Get_StringConexao()))
            {
                try
                {
                    string sSql = "";

                    sSql = " SELECT * FROM tb_login";
                    sSql += " WHERE Ativo = 1";
                    sSql += " AND Email = @email";
                    sSql += " AND  Senha =md5(@senha)";

                    MySqlCommand cmd = new MySqlCommand();

                    MySqlDataReader Dr = null;

                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    Cnn.Open();
                    cmd.CommandText = sSql;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Connection = Cnn;
                    Dr = cmd.ExecuteReader();
                    Dr.Read();

                    if (Dr.HasRows)
                    {

                        var claims1 = new[] {
                                new Claim("CodigoLogin",Dr["CodigoLogin"].ToString()),
                                new Claim("Nome",Dr["Nome"].ToString()),
                                new Claim("Email",Dr["Email"].ToString()),
                                new Claim("Tipo",Dr["Tipo"].ToString()),
                                new Claim(ClaimTypes.Role, "Logado"),
                                new Claim(ClaimTypes.Role, Dr["Tipo"].ToString()),
                        }.ToList();

                        var identity1 = new ClaimsIdentity(claims1, CookieAuthenticationDefaults.AuthenticationScheme);
                        await hcont.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(identity1));

                        return Dr["Tipo"].ToString();
                    }
                }
                catch (Exception e)
                {
                    string err = e.Message;
                }
                return "";
            }
        }


        public static string GET_DadosUser(object Context, eDadosUser Dados)
        {
            try
            {
                HttpContext hcont = null;
                try
                {
                    hcont = (HttpContext)Context;
                }
                catch
                {

                    hcont = ((IHttpContextAccessor)Context).HttpContext;
                }

                if (hcont.User.Identities.FirstOrDefault().Claims.ToList().Count == 0)
                {
                    return "";
                }

                switch (Dados)
                {
                    case eDadosUser.CodigoLogin:
                        return hcont.User.Identities.FirstOrDefault().Claims.ToList().Where(a => a.Type == "CodigoLogin").FirstOrDefault().Value;

                    case eDadosUser.Nome:
                        return hcont.User.Identities.FirstOrDefault().Claims.ToList().Where(a => a.Type == "Nome").FirstOrDefault().Value;

                    case eDadosUser.Email:
                        return hcont.User.Identities.FirstOrDefault().Claims.ToList().Where(a => a.Type == "Email").FirstOrDefault().Value;

                    case eDadosUser.Tipo:
                        return hcont.User.Identities.FirstOrDefault().Claims.ToList().Where(a => a.Type == "Tipo").FirstOrDefault().Value;

                }
            }
            catch { }

            return "";
        }
    }
}
