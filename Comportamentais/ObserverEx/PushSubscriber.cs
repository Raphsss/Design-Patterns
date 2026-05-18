using System;

public class PushSubscriber : INotificationObserver
{
    private readonly string _deviceId;

    public PushSubscriber(string deviceId) => _deviceId = deviceId;

    public void Update(Notification notification)
    {
        Console.WriteLine($"[PUSH -> {_deviceId}] Notificação push: {notification}");
        // Simulação de push
    }
}