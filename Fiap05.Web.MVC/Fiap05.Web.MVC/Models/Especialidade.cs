using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Especialidade
    {
        public int EspecialidadeId { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }

        //Relacionamentos
        //virtual -> LAZY
        public virtual List<Medico> Medicos { get; set; }
    }
}