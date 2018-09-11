using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class MedicoController : Controller
    {
        private HospitalContext _context = new HospitalContext();

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _context.Medicos.Include("Especialidade").ToList();
            return View(lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Enviar a lista de especialidades para o select
            var lista = _context.Especialidades.ToList();
            ViewBag.naoLembro = new SelectList(lista,
                "EspecialidadeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();
            TempData["msg"] = "Médico registrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}