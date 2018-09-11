using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class PessoaJuridica : Pessoa
    {
        //Construtor
        public PessoaJuridica(string nome) : base(nome)
        {
        }

        //Propriedades (Gets e Sets)
        public string Cnpj { get; set; }
        public decimal Faturamento { get; set; }
        public bool AcoesNaBolsa { get; set; }
        public TipoEmpresa Tipo { get; set; }

        //sobrescrever o método comprar
        public override void Comprar()
        {
            Console.WriteLine("PJ comprando");
        }

        public override void Vender()
        {
            Console.WriteLine("PJ vendendo");
        }
    }
}
