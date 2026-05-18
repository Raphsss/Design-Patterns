using StrategyEx.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyEx
{
    public class PaymentProcessor 
    {
        private IPayment _paymentMethod;

        public PaymentProcessor(IPayment paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void setPaymentMethod(IPayment paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }
        
        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.Pay(amount);
        }
    }
}
