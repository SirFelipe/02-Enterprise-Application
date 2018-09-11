using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    abstract class Pessoa
    {
        //Construtor ctor
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        //Campos (Atributos)
        private string _nome;

        //Propriedades (Gets e Sets)
        public string Email { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        //Métodos
        //virtual -> permite a sobrescrita do método
        public virtual void Comprar()
        {
            Console.WriteLine("Comprando");
        }

        public abstract void Vender();

    }
}
