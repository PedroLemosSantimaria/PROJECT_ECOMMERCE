using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(string nome, string username, string email, string senha)
        {
            
            Usuario u = new Usuario(nome,senha,email,username,null);
            try
            {
                TempData["msg"] = u.CadastrarCliente();
                return RedirectToAction("Login");
            }
            catch(Exception e)
            {
                TempData["msg"] = "ALGO DEU ERRADO";
                return RedirectToAction("Cadastro");
            }

           
            
        }
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(string senha, string username)
        {
            MySqlConnection con = new MySqlConnection("Server = ESN509VMYSQL; Database = phprojeto; User id = aluno; Password = Senai1234");
            MySqlCommand coman = new MySqlCommand();
            string tipoUsuario = "";




                con.Open();
                coman.Connection = con;
            coman.CommandText = "select tipousuario from usuarios where username = @username and senha = @senha";
            coman.Parameters.AddWithValue("@username", username);
            coman.Parameters.AddWithValue("@senha", senha);
            MySqlDataReader ler = coman.ExecuteReader();
            while (ler.Read())
            {




                 tipoUsuario = ler["tipousuario"].ToString();
            }
            Usuario u = new Usuario(null, senha, null, username,tipoUsuario);
            if(u.EntrarCliente())//metodo de entrar como cliente
            {
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(u));
                return RedirectToAction("Index","Home");
            }
            else
            {
                TempData["mgs"] = "ERRO";
                return RedirectToAction("Login");
            }
        }
       
        public IActionResult Sair()
        {
            HttpContext.Session.Remove("user");
           return RedirectToAction("Index", "Home");
        }
        public IActionResult Conta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Conta(string nome, string email, string senha, string username)
        {
            Usuario u = new Usuario(nome, senha, email, username,null);
            u.AlterarDados();
            return RedirectToAction("Conta");
        }

        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult CadastroAdm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroAdm(string nome, string username, string email, string senha)
        {
            Usuario u = new Usuario(nome, senha, email, username, null);
            try
            {
                TempData["msg"] = u.CadastrarAdm();
                return RedirectToAction("Index", "Home");
            }
            catch(Exception e)
            {
                TempData["msg"] = "ALGO DEU ERRADO";
                return RedirectToAction("CadastroAdm");
            }
           
        }

    }
}
