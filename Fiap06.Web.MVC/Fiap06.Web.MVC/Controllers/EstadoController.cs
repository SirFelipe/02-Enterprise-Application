using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using Fiap06.Web.MVC.UnitsOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class EstadoController : Controller
    {

        //Lista - banco
        private GeografiaContext _context = new GeografiaContext();
        private UnitOfWork _unit = new UnitOfWork();


        // GET: Estado
        public ActionResult Index()
        {
            return View();
        }

        // GET: Retorna a view de Cadastro
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        //Post para a ação de cadastrar
        [HttpPost]
        public ActionResult Cadastrar(Estado estado)
        {
            _unit.EstadoRepository.Cadastrar(estado);
            _unit.Salvar();
            TempData["msg"] = "Estado cadastrado com sucesso."; 
            //redirect para não cadastrar novamente no F5
            return RedirectToAction("Cadastrar");
        }

        //Lista
        public ActionResult Listar()
        {
            return View(_context.Estados.ToList());
        }

        //EDITAR - Retorna para a página de editar
        [HttpGet]
        public ActionResult Editar(int id)
        {
            var estado = _context.Estados.Find(id);
            return View(estado);
        }

        //EDITAR - retorna para a ação de editar
        [HttpPost]
        public ActionResult Editar(Estado estado)
        {
            _context.Entry(estado).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Estado atualizado.";
            return RedirectToAction("Listar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);

        }
    }
}