using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Units;
using Fiap07.Web.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class LivroController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Excluir(int codigo)
        {
            _unit.LivroRepository.Remover(codigo);
            _unit.Salvar();
            TempData["msg"] = "Livro removido!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Buscar(string titulo)
        {
            var livros = _unit.LivroRepository.BuscarPor(l => l.Titulo.Contains(titulo));
            var viewModel = new ListaLivroViewModel();
            viewModel.Livros = livros;
            return View("Listar", viewModel);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var viewModel = new ListaLivroViewModel();
            viewModel.Livros = _unit.LivroRepository.Listar();
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var viewModel = new LivroViewModel();
            var lista = _unit.EditoraRepository.Listar();
            viewModel.Editoras = new SelectList(lista, "EditoraId", "Nome");
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Cadastrar(Livro livro)
        {
            _unit.LivroRepository.Cadastrar(livro);
            _unit.Salvar();
            TempData["msg"] = "Livro cadastrado";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}