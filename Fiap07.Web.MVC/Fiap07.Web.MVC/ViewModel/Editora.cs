using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.ViewModel
{
    public class EditoraViewModel
    {
        public string Nome { get; set; }
        public IList<Editora> Editoras { get; set; }
    }
}