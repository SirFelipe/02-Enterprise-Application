using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nome { get; set; }

        //Relacionamentos
        public Especialidade Especialidade { get; set; }
        public int EspecialidadeId { get; set; }

        public virtual List<Consulta> Consultas { get; set; }
    }
}