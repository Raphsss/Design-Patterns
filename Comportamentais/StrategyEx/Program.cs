using StrategyEx;
using StrategyEx.Concretes;

public class Program
{
    static void Main()
    {
        PaymentProcessor processor = new PaymentProcessor(new PixPayment()); 
        processor.ProcessPayment(100.00m);

        processor.setPaymentMethod(new CreditPayment());
        processor.ProcessPayment(200.00m);

        processor.setPaymentMethod(new DebitPayment());
        processor.ProcessPayment(300.00m);

        processor.setPaymentMethod(new BoletoPayment()); 
        processor.ProcessPayment(400.00m);
    }
}