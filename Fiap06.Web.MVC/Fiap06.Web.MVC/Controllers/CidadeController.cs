using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class CidadeController : Controller
    {

        private GeografiaContext _context = new GeografiaContext();


      //CADASTRAR

      //Método que retorna a página de cadastro
      [HttpGet]
      public ActionResult Cadastrar()
        {
            var lista  = _context.Estados.ToList();
            ViewBag.estados = new SelectList(lista, "EstadoId", "Sigla");
            return View();
        }


      [HttpPost]
      public ActionResult Cadastrar(Cidade cidade)
        {
            _context.Cidades.Add(cidade);
            _context.SaveChanges();
            TempData["msg"] = "Cidade cadastrada com sucesso";

            return RedirectToAction("Cadastrar");
        }



      //LISTAR
      public ActionResult Listar()
        {
            CarregarCombo();
            var lista = _context.Cidades.Include("Estado").ToList();
            return View(lista);
        }

        private void CarregarCombo()
        {
            var ufs = _context.Estados.ToList();
            ViewBag.estados = new SelectList(ufs, "EstadoId", "Sigla");
        }

        //MÉTODO BUSCAR
        public ActionResult Buscar(int? cdEstado)
        {
            CarregarCombo();
            var lista = _context.Cidades.Include("Estado")
                .Where(c => c.EstadoId == cdEstado || cdEstado == null).ToList();

           /* if(cdEstado != null)
            {
                return View("Listar", lista);
            }
            else
            {
                RedirectToAction()
            }
            */

            return View("Listar", lista);
        }
    }
}