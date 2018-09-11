using Fiap04.Web.MVC.Models;
using Fiap04.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap04.Web.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        //Buscar por codigo
        [HttpGet]
        public ActionResult Buscar(string nomeBusca)
        {
            //Pesquisar por nome no banco
            var lista = _context.Produtos.Where(p => p.Nome.Contains(nomeBusca)).ToList();
            //Joga a lista para a tela de listar
            //Página listar e jogando a lista
            return View("Listar",lista);
        }

        //EDITAR
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var produto = _context.Produtos.Find(id);
            return View(produto);
        }

        [HttpPost]
        public ActionResult Editar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Produto atualizado!";

            return RedirectToAction("Listar");
        }

        //Lista
        private PetshopContext _context = new PetshopContext();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Produtos.ToList());
        }

        //BUSCAR POR ID
        public ActionResult Buscar(int id)
        {
            return View(_context.Produtos.Find(id));
        }


        //DELETE
        [HttpPost]
        public ActionResult Deletar(int id)
        {
            Produto produto = _context.Produtos.Find(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            TempData["msg"] = "Removido!";
            return RedirectToAction("Listar");
        }
        


        // GET: Produto para a página de cadastrar
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        //Post para a ação de cadastrar
        [HttpPost]
        public ActionResult Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            TempData["msg"] = "Produto cadastrado com sucesso.";
            //redirect para não cadastrar novamente no F5
            return RedirectToAction("Cadastrar");
        }
    }
}