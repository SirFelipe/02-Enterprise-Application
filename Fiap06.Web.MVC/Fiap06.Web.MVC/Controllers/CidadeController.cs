using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using Fiap06.Web.MVC.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class CidadeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpPost]
        public ActionResult Excluir(int codigo)
        {
            _unit.CidadeRepository.Excluir(codigo);
            _unit.Salvar();
            TempData["msg"] = "Cidade removida";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Editar(Cidade cidade)
        {
            _unit.CidadeRepository.Editar(cidade);
            _unit.Salvar();
            TempData["msg"] = "Cidade atualizada";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            CarregarCombo();
            var cidade = _unit.CidadeRepository.BuscarPorCodigo(id);
            return View(cidade);
        }

        [HttpGet]
        public ActionResult Buscar(int? estado)
        {
            CarregarCombo();
            var lista = _unit.CidadeRepository
                .BuscarPor(c => c.EstadoId == estado || estado == null);
            return View("Listar", lista);
        }

        [HttpGet]
        public ActionResult Listar()
        {
            CarregarCombo();
            var lista = _unit.CidadeRepository.Listar();
            return View(lista);
        }

        private void CarregarCombo()
        {
            var ufs = _unit.EstadoRepository.Listar();
            ViewBag.estados = new SelectList(ufs, "EstadoId", "Nome");
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            CarregarCombo();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cidade cidade)
        {
            _unit.CidadeRepository.Cadastrar(cidade);
            _unit.Salvar();
            TempData["msg"] = "Cidade cadastrada";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}