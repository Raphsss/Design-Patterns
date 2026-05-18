using System.Collections.Generic;
using System.Linq;

public class NotificationService : INotificationService
{
    private readonly List<(INotificationObserver Observer, string? Topic)> _subscribers = new();

    public void Subscribe(INotificationObserver observer, string? topic = null)
    {
        if (_subscribers.Any(s => ReferenceEquals(s.Observer, observer) && s.Topic == topic))
            return;

        _subscribers.Add((observer, topic));
    }

    public void Unsubscribe(INotificationObserver observer)
    {
        _subscribers.RemoveAll(s => ReferenceEquals(s.Observer, observer));
    }

    public void Notify(Notification notification)
    {
        // Notifica apenas assinantes sem tópico (recebem tudo) ou que têm o mesmo tópico
        foreach (var (observer, topic) in _subscribers.ToArray())
        {
            if (topic == null || topic == notification.Topic)
                observer.Update(notification);
        }
    }
}