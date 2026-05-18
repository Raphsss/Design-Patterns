namespace DecoratorEx;

public class SlackNotifierDecorator : NotifierDecorator
{
    private readonly string _channel;
    public SlackNotifierDecorator(INotifier wrappee, string channel) : base(wrappee) => _channel = channel;

    public override void Send(string message)
    {
        // delega primeiro e adiciona comportamento depois
        base.Send(message);
        Console.WriteLine($"[Slack -> {_channel}] {message}");
    }
}
