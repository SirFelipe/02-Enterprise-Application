using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    [Table("TEstado")]
    public class Estado
    {

        //[KEY]
        [Column("Id")]
        public int EstadoID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(3)]
        public string Sigla { get; set; }


        public int Populacao { get; set; }
    }
}