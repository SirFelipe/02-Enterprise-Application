using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    //[Table("TCidade")]
    public class Cidade
    {
        //[KEY]
       // [Column("Id")]
        public int CidadeID { get; set; }

        public string Nome { get; set; }
        //[Required]
        //[MaxLength(50)]

        public DateTime DataFundacao { get; set; }


        //[RELACIONAMENTOS]
        public Estado Estado { get; set; }

        public int EstadoId { get; set; }
    }
}