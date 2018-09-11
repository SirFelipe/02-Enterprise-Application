using Fiap05.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Persistencia
{
    public class HospitalContext : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Prontuario> Prontuarios { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
    }
}