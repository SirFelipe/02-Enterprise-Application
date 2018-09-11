using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fiap.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar uma conta corrente e poupança
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 100,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            var cp = new ContaPoupanca(0.06m) //m serve para forçar o parametro a ser decimal
            {
                Agencia = 1,
                Numero = 3,
                Saldo = 500,
                DataAbertura = new DateTime(2018, 1, 1),
                Taxa = 10
            };

            try
            {
                cc.Retirar(5000);
                Console.WriteLine(cc.Saldo);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine(); //Para fechar o prompt direto quando for executado

            
        }
    }
}
