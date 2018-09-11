using _02.Fiap.Exercicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;

        public ContaPoupanca(decimal r)
        {
            _rendimento = r;
        }

        public decimal Taxa { get; set; }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
