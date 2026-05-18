using DecoratorEx;

// Exemplo didático do padrão Decorator - uma classe por arquivo.

INotifier notifier = new EmailNotifier("dev@example.com");
Console.WriteLine("Base notifier:");
notifier.Send("Deployment completed.");

Console.WriteLine();
Console.WriteLine("Add SMS decorator (pre-send):");
notifier = new SmsNotifierDecorator(notifier, "+5511999999999");
notifier.Send("Deployment completed.");

Console.WriteLine();
Console.WriteLine("Add Slack decorator (post-send):");
notifier = new SlackNotifierDecorator(notifier, "#deployments");
notifier.Send("Deployment completed.");

