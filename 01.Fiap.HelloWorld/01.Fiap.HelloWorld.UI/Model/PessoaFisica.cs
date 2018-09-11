using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class PessoaFisica : Pessoa, IServico
    {
        public PessoaFisica(string nome):base(nome)
        {
        }

        //Propriedades (Gets e Sets)
        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public void Cadastrar(Pessoa p)
        {
            Console.WriteLine("Cadastrando a pessoa");
        }

        public override void Vender()
        {
            Console.WriteLine("PF vendendo");
        }
    }
}
