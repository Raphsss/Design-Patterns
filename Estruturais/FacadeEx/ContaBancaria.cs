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
        private decimal Saldo { get; set; }

        public ContaBancaria(string numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
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
