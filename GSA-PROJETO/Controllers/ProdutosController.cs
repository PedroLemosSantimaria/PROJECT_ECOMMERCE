using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult CadastrarProduto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProduto(string tipoP, string nome, string codigo, string descricao, string preco, string tamanho, string marca,int estoque)
        {
            IFormFile arquivo = Request.Form.Files[0];
            string tipoArquivo = arquivo.ContentType;
            if (tipoArquivo.Contains("png") ||
                    tipoArquivo.Contains("jpeg"))
            {//Gravar no banco
             //converter a imagem em bytes
                MemoryStream s = new MemoryStream();
                arquivo.CopyToAsync(s);
                byte[] bytesArquivo = s.ToArray();
                Produtos p = new Produtos(tipoP, nome, codigo, descricao, preco, tamanho, marca, bytesArquivo,estoque);
                p.cadastarProduto();
            }
            return RedirectToAction("CadastrarProduto");
        }
        public IActionResult Listar()
        {
            return View(Produtos.Listar());
        }
        public IActionResult Excluir(string cod)
        {
            Produtos p = new Produtos(null, null, cod, null, null, null, null, null,0);
            TempData["msg"] = p.Excluir();
            return RedirectToAction("Listar");
        }
        public IActionResult Alterar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Alterar(int estoque,String codigo)
        {
            Produtos p = new Produtos(null,null,codigo,null,null,null,null,null,estoque);
            TempData["mgs"] = p.Alterar();
            return RedirectToAction("Listar");
        }
        public IActionResult Skate()
        {

            return View(Produtos.Skate()); 
        }

        public IActionResult Moletom()
        {
            return View(Produtos.Moletom());
        }
    }
}
