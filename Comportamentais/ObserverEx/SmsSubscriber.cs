using System;

public class SmsSubscriber : INotificationObserver
{
    private readonly string _phone;

    public SmsSubscriber(string phone) => _phone = phone;

    public void Update(Notification notification)
    {
        Console.WriteLine($"[SMS -> {_phone}] Enviando SMS: {notification}");
        // Simulação de envio SMS
    }
}