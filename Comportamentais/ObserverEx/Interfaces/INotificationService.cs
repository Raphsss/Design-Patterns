public interface INotificationService
{
    void Subscribe(INotificationObserver observer, string? topic = null);
    void Unsubscribe(INotificationObserver observer);
    void Notify(Notification notification);
}