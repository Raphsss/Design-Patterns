using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEx.Concretes
{
    public class BoletoPayment : Interface.IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Pagando via Boleto.");
        }
    }
}
