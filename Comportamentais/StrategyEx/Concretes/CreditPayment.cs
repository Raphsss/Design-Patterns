using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEx.Concretes
{
    public class CreditPayment : Interface.IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Pagando via Crédito.");
        }
    }
}
