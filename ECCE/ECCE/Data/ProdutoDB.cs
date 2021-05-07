using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ECCE.Classes;
using ECCE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace ECCE.Data
{
    public class ProdutoDB
    {

        public bool InserirDados(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };

                
                obj.JsonLTFoto = obj.JsonLTFoto.Replace("Descricao", "Caminho");
                //obj.JsonLTCor = obj.JsonLTCor.Replace("Codigo", "CodigoCor");
                //obj.JsonLTCategoria = obj.JsonLTCategoria.Replace("Codigo", "CodigoCategoria");
                obj.JsonLTGenero = obj.JsonLTGenero.Replace("Codigo", "CodigoGenero");
                obj.JsonLTTamanho = obj.JsonLTTamanho.Replace("Codigo", "CodigoTamanho");


                var prodFotos = JsonConvert.DeserializeObject<List<tb_produto_foto>>(obj.JsonLTFoto, settings);
                //var proCores = JsonConvert.DeserializeObject<List<tb_produto_cor>>(obj.JsonLTCor, settings);
                //var proCategorias = JsonConvert.DeserializeObject<List<tb_produto_categoria>>(obj.JsonLTCategoria, settings);
                var proGeneros = JsonConvert.DeserializeObject<List<tb_produto_genero>>(obj.JsonLTGenero, settings);
                var proTamanhos = JsonConvert.DeserializeObject<List<tb_produto_tamanho>>(obj.JsonLTTamanho , settings);


                sSQL = "insert into tb_produto (CodigoInterno, Nome, Descricao, valor, dataregistro, peso, ativo)values(@codigointerno, @nome, @descricao, @valor, Now(), @peso, @ativo)";
                cmd.Parameters.AddWithValue("@codigointerno", obj.tb_produto.CodigoInterno);
                cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.tb_produto.Descricao);
                cmd.Parameters.AddWithValue("@valor", obj.tb_produto.Valor);
                cmd.Parameters.AddWithValue("@peso", obj.tb_produto.Peso);
                cmd.Parameters.AddWithValue("@ativo", obj.tb_produto.Ativo);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                int result = cmd.ExecuteNonQuery();

                if (result==1) {
                    int CodigoProduto = 0;
                    cmd.Parameters.Clear();
                    sSQL = "select CodigoProduto from tb_produto order by CodigoProduto desc limit 1 ";
                    cmd.CommandText = sSQL;
                    var DrCodP = cmd.ExecuteReader();

                    if (DrCodP.HasRows)
                    {
                        DrCodP.Read();
                        CodigoProduto = Convert.ToInt32(DrCodP["CodigoProduto"].ToString());
                        DrCodP.Close();
                    }
                    else {
                        return false;
                    }

                    //Fotos
                    foreach (var item in prodFotos) {
                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_produto_foto (CodigoProduto,Caminho)values(@CodigoProduto,@Caminho)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Caminho", item.Caminho);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    string Tabela = "";
                    string Coluna = "";
                    int Codigo = 0;
                    /*
                    //Cores                                 
                    foreach (var item in proCores)
                    {
                        Tabela = "tb_produto_cor";
                        Coluna = "CodigoCor";
                        Codigo = item.CodigoCor;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;                        
                        sSQL = "insert into  " + Tabela + " ("+ Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";                        
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }


                    //Categorias                    
                    foreach (var item in proCategorias)
                    {
                        Tabela = "tb_produto_categoria";
                        Coluna = "CodigoCategoria";
                        Codigo = item.CodigoCategoria;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }
                    */
                    //Generos                    
                    foreach (var item in proGeneros)
                    {
                        Tabela = "tb_produto_genero";
                        Coluna = "CodigoGenero";
                        Codigo = item.CodigoGenero;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    //Tamanhos                    
                    foreach (var item in proTamanhos)
                    {
                        Tabela = "tb_produto_tamanho";
                        Coluna = "CodigoTamanho";
                        Codigo = item.CodigoTamanho;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }


                }


                return true;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public bool UpdateDados(ProdutoModel obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore,
                    Culture = new System.Globalization.CultureInfo("pt-BR")
                };


                obj.JsonLTFoto = obj.JsonLTFoto.Replace("Descricao", "Caminho");
                //obj.JsonLTCor = obj.JsonLTCor.Replace("Codigo", "CodigoCor");
                //obj.JsonLTCategoria = obj.JsonLTCategoria.Replace("Codigo", "CodigoCategoria");
                obj.JsonLTGenero = obj.JsonLTGenero.Replace("Codigo", "CodigoGenero");
                obj.JsonLTTamanho = obj.JsonLTTamanho.Replace("Codigo", "CodigoTamanho");


                var prodFotos = JsonConvert.DeserializeObject<List<tb_produto_foto>>(obj.JsonLTFoto, settings);
                //var proCores = JsonConvert.DeserializeObject<List<tb_produto_cor>>(obj.JsonLTCor, settings);
                //var proCategorias = JsonConvert.DeserializeObject<List<tb_produto_categoria>>(obj.JsonLTCategoria, settings);
                var proGeneros = JsonConvert.DeserializeObject<List<tb_produto_genero>>(obj.JsonLTGenero, settings);
                var proTamanhos = JsonConvert.DeserializeObject<List<tb_produto_tamanho>>(obj.JsonLTTamanho, settings);


                sSQL = " update tb_produto set CodigoInterno=@codigointerno, Nome=@nome,Descricao=@descricao,valor=@valor,peso=@peso, ativo=@ativo" +
                       " where CodigoProduto=" + obj.tb_produto.CodigoProduto;

                cmd.Parameters.AddWithValue("@codigointerno", obj.tb_produto.CodigoInterno);
                cmd.Parameters.AddWithValue("@nome", obj.tb_produto.Nome);
                cmd.Parameters.AddWithValue("@descricao", obj.tb_produto.Descricao);
                cmd.Parameters.AddWithValue("@valor", obj.tb_produto.Valor);                
                cmd.Parameters.AddWithValue("@peso", obj.tb_produto.Peso);
                cmd.Parameters.AddWithValue("@ativo", obj.tb_produto.Ativo);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    sSQL = " delete from tb_produto_foto where CodigoProduto=" + obj.tb_produto.CodigoProduto +";";
                    sSQL += "delete from tb_produto_cor where CodigoProduto=" + obj.tb_produto.CodigoProduto + ";";
                    sSQL += "delete from tb_produto_categoria where CodigoProduto=" + obj.tb_produto.CodigoProduto + ";";
                    sSQL += "delete from tb_produto_genero where CodigoProduto=" + obj.tb_produto.CodigoProduto + ";";
                    sSQL += "delete from tb_produto_tamanho where CodigoProduto=" + obj.tb_produto.CodigoProduto + ";";
                    cmd.Parameters.Clear();
                    cmd.Connection = cn;
                    cmd.CommandText = sSQL;
                    cmd.ExecuteNonQuery();

                    //Fotos
                    foreach (var item in prodFotos)
                    {
                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  tb_produto_foto (CodigoProduto,Caminho)values(@CodigoProduto,@Caminho)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Caminho", item.Caminho);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    string Tabela = "";
                    string Coluna = "";
                    int Codigo = 0;
                    /*
                    //Cores                                 
                    foreach (var item in proCores)
                    {
                        Tabela = "tb_produto_cor";
                        Coluna = "CodigoCor";
                        Codigo = item.CodigoCor;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }


                    //Categorias                    
                    foreach (var item in proCategorias)
                    {
                        Tabela = "tb_produto_categoria";
                        Coluna = "CodigoCategoria";
                        Codigo = item.CodigoCategoria;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }
                    */
                    //Generos                    
                    foreach (var item in proGeneros)
                    {
                        Tabela = "tb_produto_genero";
                        Coluna = "CodigoGenero";
                        Codigo = item.CodigoGenero;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    //Tamanhos                    
                    foreach (var item in proTamanhos)
                    {
                        Tabela = "tb_produto_tamanho";
                        Coluna = "CodigoTamanho";
                        Codigo = item.CodigoTamanho;

                        cmd.Parameters.Clear();
                        cmd.Connection = cn;
                        sSQL = "insert into  " + Tabela + " (" + Coluna + ",CodigoProduto)values(@Codigo,@CodigoProduto)";
                        cmd.Parameters.AddWithValue("@CodigoProduto", obj.tb_produto.CodigoProduto);
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.CommandText = sSQL;
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }


                return false;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return false;
            }
        }

        public List<SelectListItem> GetCategoria()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_categoria";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoCategoria"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetCor()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_cor";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoCor"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

 
        public List<SelectListItem> GetGenero()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_genero";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoGenero"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public List<SelectListItem> GetTamanho()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_tamanho";
                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                List<SelectListItem> LT = new List<SelectListItem>();

                while (Dr.Read())
                {
                    var item = new SelectListItem
                    {
                        Value = Dr["CodigoTamanho"].ToString(),
                        Text = Dr["Descricao"].ToString(),
                    };

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }
        }

        public bool ValidarNome(tb_produto obj)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where nome=@nome";
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

        public List<tb_produto> GetAllProduto()
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto order by nome";

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<tb_produto>();

                while (Dr.Read())
                {
                    var item = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),

                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
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

        public ProdutoModel GetProduto(int CodigoProduto) {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where CodigoProduto=@CodigoProduto";
                cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var ProdM = new ProdutoModel();

                tb_produto tbPro=null;

                while (Dr.Read())
                {
                    tbPro = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
                        
                    };
                   
                }

                ProdM.tb_produto = tbPro;
                ProdM.JsonLTCategoria = JsonConvert.SerializeObject(GetProdutoCategoria(CodigoProduto));
                ProdM.JsonLTCor =  JsonConvert.SerializeObject(GetProdutoCor(CodigoProduto));
                ProdM.JsonLTFoto = JsonConvert.SerializeObject(GetProdutoFoto(CodigoProduto));
                ProdM.JsonLTGenero = JsonConvert.SerializeObject(GetProdutoGenero(CodigoProduto));
                ProdM.JsonLTTamanho = JsonConvert.SerializeObject(GetProdutoTamanho(CodigoProduto));


                return ProdM;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }

        public List<produtocorModel> GetProdutoCor(int CodigoProduto)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_cor as A,tb_cor as B" +
                       " WHERE A.CodigoCor=B.CodigoCor" +
                       " AND A.CodigoProduto=" + CodigoProduto;                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtocorModel>();

                while (Dr.Read())
                {
                    var item = new produtocorModel
                    {
                        CodigoCor = Convert.ToInt32(Dr["CodigoCor"]),
                        CodigoProduto = CodigoProduto,
                        Descricao= Dr["Descricao"].ToString()
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
        public List<produtogeneroModel> GetProdutoGenero(int CodigoProduto)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_genero as A,tb_genero as B" +
                       " WHERE A.CodigoGenero=B.CodigoGenero" +
                       " AND A.CodigoProduto=" + CodigoProduto;                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtogeneroModel>();

                while (Dr.Read())
                {
                    var item = new produtogeneroModel
                    {
                        CodigoGenero = Convert.ToInt32(Dr["CodigoGenero"]),
                        CodigoProduto = CodigoProduto,
                        Descricao= Dr["Descricao"].ToString()
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
        public List<produtotamanhoModel> GetProdutoTamanho(int CodigoProduto)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_tamanho as A,tb_tamanho as B" +
                     " WHERE A.CodigoTamanho=B.CodigoTamanho" +
                     " AND A.CodigoProduto=" + CodigoProduto;
                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtotamanhoModel>();

                while (Dr.Read())
                {
                    var item = new produtotamanhoModel
                    {
                        CodigoTamanho = Convert.ToInt32(Dr["CodigoTamanho"]),
                        CodigoProduto = CodigoProduto,
                        Descricao= Dr["Descricao"].ToString()
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
        public List<produtocategoriaModel> GetProdutoCategoria(int CodigoProduto)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_categoria as A,tb_categoria as B" +
                       " WHERE A.CodigoCategoria=B.CodigoCategoria"+
                       " AND A.CodigoProduto=" + CodigoProduto;

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtocategoriaModel>();

                while (Dr.Read())
                {
                    var item = new produtocategoriaModel
                    {
                        CodigoCategoria = Convert.ToInt32(Dr["CodigoCategoria"]),
                        CodigoProduto = CodigoProduto,
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
        public List<produtofotoModel> GetProdutoFoto(int CodigoProduto)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = " Select A.*,B.* from tb_produto_foto as A,tb_produto as B" +
                       " WHERE A.CodigoProduto=B.CodigoProduto" +
                       " AND A.CodigoProduto=" + CodigoProduto;                

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var Lista = new List<produtofotoModel>();

                while (Dr.Read())
                {
                    var item = new produtofotoModel
                    {
                        CodigoFoto = Convert.ToInt32(Dr["CodigoFoto"]),
                        Descricao = Dr["Caminho"].ToString(),                        
                        CodigoProduto = CodigoProduto
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
        public List<ProdutoVWList> GetProdutoVWList()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select *," +
                    "(select Caminho from tb_produto_foto where tb_produto_foto.CodigoProduto=tb_produto.CodigoProduto limit 1) as Foto" +
                    " from tb_produto ";            

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
                    };

                    item.Foto = Dr["Foto"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }


        public List<ProdutoVWList> GetProdutoVWListInfantil()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho," +
                        "g.CodigoGenero from tb_produto AS p JOIN tb_produto_genero AS g ON g.CodigoProduto = p.CodigoProduto LEFT JOIN tb_produto_foto " +
                        "AS f ON f.CodigoProduto = p.CodigoProduto WHERE g.CodigoGenero = 9 GROUP BY p.CodigoProduto";


                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }

        public List<ProdutoVWList> GetProdutoVWListFeminino()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho," +
                        "g.CodigoGenero from tb_produto AS p JOIN tb_produto_genero AS g ON g.CodigoProduto = p.CodigoProduto " +
                        "LEFT JOIN tb_produto_foto AS f ON f.CodigoProduto = p.CodigoProduto WHERE g.CodigoGenero = 13 GROUP BY p.CodigoProduto";


                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }


        public List<ProdutoVWList> GetProdutoVWListMasculino()
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "SELECT p.CodigoProduto, p.CodigoInterno, p.Nome, p.Descricao, p.Valor, p.DataRegistro, p.Peso, p.Ativo, f.Caminho," +
                        "g.CodigoGenero from tb_produto AS p JOIN tb_produto_genero AS g ON g.CodigoProduto = p.CodigoProduto " +
                        "LEFT JOIN tb_produto_foto AS f ON f.CodigoProduto = p.CodigoProduto WHERE g.CodigoGenero=7 GROUP BY p.CodigoProduto";


                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
                    };

                    item.Foto = Dr["Caminho"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }


        public ProdutoView GetProdutoView(int CodigoProduto)
        {
            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select * from tb_produto where CodigoProduto=@CodigoProduto";
                cmd.Parameters.AddWithValue("@CodigoProduto", CodigoProduto);

                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var ProdM = new ProdutoView();

                tb_produto tbPro = null;

                while (Dr.Read())
                {
                    tbPro = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),

                    };

                }

                ProdM.tb_produto = tbPro;
                ProdM.produtocategoriaModel =GetProdutoCategoria(CodigoProduto);
                ProdM.produtocorModel = GetProdutoCor(CodigoProduto);
                ProdM.produtofotoModel = GetProdutoFoto(CodigoProduto);
                ProdM.produtogeneroModel =GetProdutoGenero(CodigoProduto);
                ProdM.produtotamanhoModel = GetProdutoTamanho(CodigoProduto);


                return ProdM;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }

        public List<ProdutoVWList> GetProdutoVWListProcura(string nome)
        {

            try
            {
                string sSQL = "";
                MySqlCommand cmd = new MySqlCommand();
                MySqlConnection cn = new MySqlConnection(CConexao.Get_StringConexao());
                cn.Open();

                sSQL = "select *," +
                    "(select Caminho from tb_produto_foto where tb_produto_foto.CodigoProduto=tb_produto.CodigoProduto limit 1) as Foto" +
                    " from tb_produto where tb_produto.nome=@nome";
                cmd.Parameters.AddWithValue("@nome", nome);


                cmd.CommandText = sSQL;
                cmd.Connection = cn;
                var Dr = cmd.ExecuteReader();

                var LT = new List<ProdutoVWList>();

                while (Dr.Read())
                {
                    var item = new ProdutoVWList();

                    item.tb_produto = new tb_produto
                    {
                        CodigoProduto = Convert.ToInt32(Dr["CodigoProduto"]),
                        CodigoInterno = Dr["CodigoInterno"].ToString(),
                        Nome = Dr["Nome"].ToString(),
                        Descricao = Dr["Descricao"].ToString(),
                        Valor = Convert.ToDecimal(Dr["Valor"]),
                        DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]),
                        Peso = Convert.ToDouble(Dr["Peso"]),
                        Ativo = Convert.ToInt32(Dr["Ativo"]),
                    };

                    item.Foto = Dr["Foto"].ToString();

                    LT.Add(item);
                }

                return LT;
            }
            catch (Exception e)
            {
                string msg = e.Message;
                return null;
            }

        }



    }
}
