using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap04.Web.MVC.Models
{
    [Table("TProduto")]
    public class Produto
    {
        
        //[Key]
        [Column("Id")]
        public int ProdutoId { get; set; }

        public string Descricao{ get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public DateTime Validade { get; set; }
    }
}