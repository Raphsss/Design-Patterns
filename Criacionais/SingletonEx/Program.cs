using SingletonEx;

public class Program()
{
    public static void Main(string[] args)
    {
        Logger logger = Logger.Instance;
        logger.Log("Singleton implementado!");
    }
}