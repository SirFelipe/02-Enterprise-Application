using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Persistencia
{
    public class LivrariaContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Editora> Editoras { get; set; }
    }
}