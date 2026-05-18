namespace DecoratorEx;

public class EmailNotifier : INotifier
{
    private readonly string _emailAddress;
    public EmailNotifier(string emailAddress) => _emailAddress = emailAddress;

    public void Send(string message)
    {
        Console.WriteLine($"[Email -> {_emailAddress}] {message}");
    }
}
