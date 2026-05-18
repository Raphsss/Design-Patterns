    using System;

public class Program
{
    static void Main()
    {
        var service = new NotificationService();

        var emailAll = new EmailSubscriber("user@exemplo.com");      
        var smsAlerts = new SmsSubscriber("+5511999000000");           
        var pushNews = new PushSubscriber("device-1234");             

        service.Subscribe(emailAll);                    // sem tópico => recebe todas
        service.Subscribe(smsAlerts, topic: "alerts");
        service.Subscribe(pushNews, topic: "news");

        Console.WriteLine("Enviando notificação de 'news'...");
        service.Notify(new Notification("news", "Novo artigo publicado."));

        Console.WriteLine();
        Console.WriteLine("Enviando notificação de 'alerts'...");
        service.Notify(new Notification("alerts", "Alerta crítico: verifique o sistema."));

        Console.WriteLine();
        Console.WriteLine("Removendo assinante de email e enviando outra 'news'...");
        service.Unsubscribe(emailAll);
        service.Notify(new Notification("news", "Segunda chamada: atualização do artigo."));

        Console.WriteLine();
        Console.WriteLine("Fim da demonstração.");
    }
}