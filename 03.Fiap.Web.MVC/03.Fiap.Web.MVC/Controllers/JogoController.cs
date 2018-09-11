using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class JogoController : Controller
    {
        //simula o banco de dados
        private static List<Jogo> _banco = new List<Jogo>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco); //envia a lista para a tela
        }

        // GET: Jogo/Cadastrar
        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Passar a lista de plataforma
            var lista = new List<string>();
            lista.Add("PC");
            lista.Add("PS4");
            lista.Add("Xbox One");

            ViewBag.plataformas = new SelectList(lista);

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogo jogo)
        {
            _banco.Add(jogo); //cadastra no "banco"
            TempData["msg"]  = "Cadastrado com sucesso!";
            //redirect para não cadastrar novamente no F5
            return RedirectToAction("Cadastrar");
        }
    }
}