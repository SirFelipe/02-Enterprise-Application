using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.ViewModel
{
    public class ListaLivroViewModel
    {
        public string Titulo { get; set; }
        public IList<Livro> Livros { get; set; }
        public int Codigo { get; set; }
    }
}