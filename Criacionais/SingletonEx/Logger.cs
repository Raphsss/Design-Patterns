namespace SingletonEx
{
    public class Logger
    {
        private static Logger _instance;

        public static Logger Instance
        {
            get
            {
                if (_instance == null) { _instance = new Logger(); }
  
                return _instance;
            }
        }

        private Logger() { } // Evita que se possa istanciar a classe diretamente

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
