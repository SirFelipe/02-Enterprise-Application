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
    public class EditoraController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var viewModel = new EditoraViewModel();
            viewModel.Editoras = _unit.EditoraRepository.Listar();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Cadastrar(Editora editora)
        {
            _unit.EditoraRepository.Cadastrar(editora);
            _unit.Salvar();
            TempData["msg"] = "Editora Cadastrada";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}