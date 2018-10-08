using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string Nome { get; set; }

        public IList<Livro> Livros { get; set; }
    }
}