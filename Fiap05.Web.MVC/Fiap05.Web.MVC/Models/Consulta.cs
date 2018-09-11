using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public DateTime Data { get; set; }
        public int Consultorio { get; set; }

        //Relacionamentos
        public Medico Medico { get; set; }
        public int MedicoId { get; set; }
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }
    }
}