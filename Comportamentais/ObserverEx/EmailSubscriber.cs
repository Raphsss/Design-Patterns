using System;

public class EmailSubscriber : INotificationObserver
{
    private readonly string _email;

    public EmailSubscriber(string email) => _email = email;

    public void Update(Notification notification)
    {
        Console.WriteLine($"[EMAIL -> {_email}] Enviando email: {notification}");
    }
}