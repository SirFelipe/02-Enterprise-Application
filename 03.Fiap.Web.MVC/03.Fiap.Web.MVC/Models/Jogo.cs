using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _03.Fiap.Web.MVC.Models
{
    public class Jogo
    {
        public string Nome { get; set; }

        [Display(Name = "Genêro")]
        public string Genero { get; set; }

        public bool Demo { get; set; }

        public string Plataforma { get; set; }

        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Idade mínima")]
        public int IdadeMinima { get; set; }
    }
}