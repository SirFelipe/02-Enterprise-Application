using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar Pessoa Fisica
            PessoaFisica pf = new PessoaFisica("Ronado");
            pf.Nome = "Ronaldo"; //set
            Console.WriteLine(pf.Nome); //get

            //Instanciar a Pessoa Juridica
            PessoaJuridica pj = new PessoaJuridica("Fiap")
            {
                Email = "pf@pf.com",
                AcoesNaBolsa = false
            };

            var pf2 = new PessoaFisica("Juliana");
            var pj2 = new PessoaJuridica("Coca-Cola");

            Console.ReadLine();
            
        }
    }
}
