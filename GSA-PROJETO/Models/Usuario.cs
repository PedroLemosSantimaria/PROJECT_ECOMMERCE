using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{

    public class Usuario
    {
        string conexao = "Server=ESN509VMYSQL;Database=phprojeto;User id=aluno;Password=Senai1234";
        private string nome, senha, email, username,tipoUsuario;

        public Usuario(string nome, string senha, string email, string username,string tipoUsuario)
        {
            this.nome = nome;
            this.senha = senha;
            this.email = email;
            this.username = username;
            this.tipoUsuario = tipoUsuario;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

        public string CadastrarCliente()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            try
            {
                tipoUsuario = "Cliente";
                con.Open();
                coman.Connection = con;
                coman.CommandText = "insert into usuarios values(@username,@nome,@email,@senha,@tipo)";
                coman.Parameters.AddWithValue("@nome", nome);
                coman.Parameters.AddWithValue("@username", username);
                coman.Parameters.AddWithValue("@email", email);
                coman.Parameters.AddWithValue("@senha", senha);
                coman.Parameters.AddWithValue("@tipo",tipoUsuario );
                
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


        public bool EntrarCliente()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {


                MySqlCommand coman = new MySqlCommand();
                con.Open();
                coman.Connection = con;
                coman.CommandText = "Select username , senha from usuarios where username = @username and senha = @senha";
                coman.Parameters.AddWithValue("@username", username);
                coman.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader leitor = coman.ExecuteReader();
                leitor.Read();
                if (leitor.HasRows)
                {
                   


                    return true;
                }
                else
                {
                    return false;
                }

            }catch(Exception e)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public string AlterarDados()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            try
            {
                con.Open();
                coman.Connection = con;
                coman.CommandText = "UPDATE usuarios SET nome = @nome , senha = @senha , email = @email   WHERE username = @username";
                coman.Parameters.AddWithValue("@nome", nome);
                coman.Parameters.AddWithValue("@username", username);
                coman.Parameters.AddWithValue("@email", email);
                coman.Parameters.AddWithValue("@senha", senha);
                coman.ExecuteNonQuery();
                return "Alterado Com Sucesso";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string CadastrarAdm()
        {
            MySqlConnection con = new MySqlConnection(conexao);
            MySqlCommand coman = new MySqlCommand();
            try
            {
                tipoUsuario = "Adm";
                con.Open();
                coman.Connection = con;
                coman.CommandText = "insert into usuarios values(@username,@nome,@email,@senha,@tipo)";
                coman.Parameters.AddWithValue("@nome", nome);
                coman.Parameters.AddWithValue("@username", username);
                coman.Parameters.AddWithValue("@email", email);
                coman.Parameters.AddWithValue("@senha", senha);
                coman.Parameters.AddWithValue("@tipo", tipoUsuario);

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

    }
}

