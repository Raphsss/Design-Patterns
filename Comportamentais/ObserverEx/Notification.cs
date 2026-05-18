using System;

public sealed class Notification
{
    public string Topic { get; }
    public string Message { get; }
    public DateTime Timestamp { get; }

    public Notification(string topic, string message)
    {
        Topic = topic;
        Message = message;
        Timestamp = DateTime.UtcNow;
    }

    public override string ToString() => $"[{Timestamp:O}] ({Topic}) {Message}";
}