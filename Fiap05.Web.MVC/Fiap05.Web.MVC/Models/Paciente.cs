using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }

        public string Nome { get; set; }

        //Relacionamentos
        public int ProntuarioId { get; set; }
        public Prontuario Prontuario { get; set; }

        public virtual List<Consulta> Consultas { get; set; }

        public virtual List<Convenio> Convenios { get; set; }
    }
}