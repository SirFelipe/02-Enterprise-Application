using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class EspecialidadeController : Controller
    {
        private HospitalContext _context = new HospitalContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Especialidade especialidade)
        {
            _context.Especialidades.Add(especialidade);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            var esp = _context.Especialidades.Find(id);
            return View(esp);
        }

        [HttpPost]
        public ActionResult Editar(Especialidade especialidade)
        {
            _context.Entry(especialidade).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado com sucesso";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Especialidades.ToList();
            return View(lista);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            var esp = _context.Especialidades.Find(id);
            _context.Especialidades.Remove(esp);
            _context.SaveChanges();
            TempData["msg"] = "Removido com sucesso";
            return RedirectToAction("Listar");
        }
    }
}