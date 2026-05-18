namespace DecoratorEx;

public class SmsNotifierDecorator : NotifierDecorator
{
    private readonly string _phone;
    public SmsNotifierDecorator(INotifier wrappee, string phone) : base(wrappee) => _phone = phone;

    public override void Send(string message)
    {
        // comportamento adicional antes de delegar
        Console.WriteLine($"[SMS -> {_phone}] {message}");
        base.Send(message);
    }
}
