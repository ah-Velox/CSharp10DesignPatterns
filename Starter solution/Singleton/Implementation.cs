namespace Singleton
{
    // Singleton
    class Logger
    {
        private static Logger? _instance;
        private Logger() { }

        // Singleton Instance
        public static Logger? Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        // Singleton Operation
        public void Log(string message) { 
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
