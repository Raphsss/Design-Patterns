using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeEx
{
    public class ContaBancaria
    {
        public string NumeroConta { get; }
        public string Titular { get; }
        public decimal Saldo { get; private set; }

        public ContaBancaria(string NumeroConta, string Titular)
        {
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }
    }
}
