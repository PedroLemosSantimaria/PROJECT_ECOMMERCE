using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Produtos
    {
       static string conexao = "Server=ESN509VMYSQL;Database=phprojeto;User id=aluno;Password=Senai1234";
       
        
        private string tipoP, nome, codigo, descricao, preco, tamanho, marca;
        private int estoque;
        private byte[] bytesArquivo;




        public Produtos(string tipoP, string nome, string codigo, string descricao, string preco, string tamanho, string marca, byte[] bytesArquivo,int estoque)
        {
            this.tipoP = tipoP;
            this.nome = nome;
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;
            this.tamanho = tamanho;
            this.marca = marca;
            this.bytesArquivo = bytesArquivo;
            this.estoque = estoque;
            
        }
        public string cadastarProduto()

        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            
            try
            {
                con.Open();
                coman.Connection = con;
                coman.CommandText = "insert into produtos values(@marca,@nome,@tamanho,@codigo,@img,@descricao,@tipoproduto,@preco,@estoque)";
                coman.Parameters.AddWithValue("@nome", nome);
                coman.Parameters.AddWithValue("@codigo", codigo);
                coman.Parameters.AddWithValue("@preco", preco);
                coman.Parameters.AddWithValue("@descricao", descricao);
                coman.Parameters.AddWithValue("@marca", marca);
                coman.Parameters.AddWithValue("@tamanho", tamanho);
                coman.Parameters.AddWithValue("@img",bytesArquivo);
                coman.Parameters.AddWithValue("@tipoproduto", tipoP);
                coman.Parameters.AddWithValue("@estoque", estoque);
                coman.ExecuteNonQuery();

                return "Cadastro Concluido";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                con.Close();
            }

        }
        public static List<Produtos> Listar()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            List<Produtos> lista = new List<Produtos>();
            con.Open();
            coman.Connection = con;
            coman.CommandText = "select * from produtos";
            MySqlDataReader ler = coman.ExecuteReader();
            while (ler.Read())
            {
                byte[] imgB = (byte[])ler["img"];
               string imagem= Convert.ToBase64String(imgB);
                Produtos p = new Produtos(
                    ler["tipoProduto"].ToString(),
                    ler["nome"].ToString(),
                    ler["codProduto"].ToString(),
                    ler["descricao"].ToString(),
                    ler["preco"].ToString(),
                    ler["tamanho"].ToString(),
                    ler["marca"].ToString(),
                    imgB,
                     (int)ler["estoque"]);
                
                lista.Add(p);
            }
            con.Close();
            return lista;
        }
        public string Excluir()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            try
            {
                con.Open();
                coman.Connection = con;
                coman.CommandText = "DELETE FROM produtos WHERE codProduto = @codigo";
                coman.Parameters.AddWithValue("@codigo", codigo);
                coman.ExecuteNonQuery();
                return "Excluido com Exito";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                con.Close();
            }

        }

        public string Alterar()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            try
            {
                con.Open();
                coman.Connection = con;
                coman.CommandText = "UPDATE produtos SET estoque = @estoque WHERE codProduto = @codigo";
                coman.Parameters.AddWithValue("@estoque", estoque);
                coman.Parameters.AddWithValue("@codigo", codigo);
                coman.ExecuteNonQuery();
                return "Alterado Com Sucesso";
            }
            catch(Exception e)
            {
                return e.Message;
            }

        }
        public static List<Produtos> Skate()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            List<Produtos> lista = new List<Produtos>();
            try
            {
                con.Open();
                coman.Connection = con;
                coman.CommandText = "SELECT marca,nome,tamanho,codProduto,img,descricao,tipoProduto,preco,estoque from produtos where tipoProduto = 'skate'";
                
                MySqlDataReader ler = coman.ExecuteReader();
                while (ler.Read())
                {
                    byte[] imgB = (byte[])ler["img"];
                    string imagem = Convert.ToBase64String(imgB);
                    Produtos p = new Produtos(
                        ler["tipoProduto"].ToString(),
                        ler["nome"].ToString(),
                        ler["codProduto"].ToString(),
                        ler["preco"].ToString(),
                        ler["descricao"].ToString(),
                        ler["tamanho"].ToString(),
                        ler["marca"].ToString(),
                        imgB,
                         (int)ler["estoque"]);

                    lista.Add(p);
                }
                con.Close();
                return lista;

            }
            catch(Exception e)
            {
                return null;
            }

        }
        public static List<Produtos> Moletom()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            List<Produtos> lista = new List<Produtos>();
            try
            {
                con.Open();
                coman.Connection = con;
                coman.CommandText = "SELECT marca,nome,tamanho,codProduto,img,descricao,tipoProduto,preco,estoque from produtos where tipoProduto = 'moletom'";

                MySqlDataReader ler = coman.ExecuteReader();
                while (ler.Read())
                {
                    byte[] imgB = (byte[])ler["img"];
                    string imagem = Convert.ToBase64String(imgB);
                    Produtos p = new Produtos(
                        ler["tipoProduto"].ToString(),
                        ler["nome"].ToString(),
                        ler["codProduto"].ToString(),
                        ler["preco"].ToString(),
                        ler["descricao"].ToString(),
                        ler["tamanho"].ToString(),
                        ler["marca"].ToString(),
                        imgB,
                         (int)ler["estoque"]);

                    lista.Add(p);
                }
                con.Close();
                return lista;

            }
            catch (Exception e)
            {
                return null;
            }

        }





        public string TipoP { get => tipoP; set => tipoP = value; }

        public string Nome { get => nome; set => nome = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Preco { get => preco; set => preco = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public string Marca { get => marca; set => marca = value; }
        public byte[] BytesArquivo { get => bytesArquivo; set => bytesArquivo = value; }
        public int Estoque { get => estoque; set => estoque = value; }
    }
}
