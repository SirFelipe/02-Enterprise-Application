using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.ViewModel
{
    public class LivroViewModel
    {
        public string Titulo { get; set; }
        public int Paginas { get; set; }
        public int EditoraId { get; set; }
        public SelectList Editoras { get; set; }
    }
}