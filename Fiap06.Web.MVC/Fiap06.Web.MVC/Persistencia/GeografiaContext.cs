using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Persistencia
{
    //Classe que gerencia as tabelas no banco
    public class GeografiaContext : DbContext
    {
        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Estado> Estados { get; set; }
    }
}