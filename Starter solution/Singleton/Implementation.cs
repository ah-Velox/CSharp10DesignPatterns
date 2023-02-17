namespace Singleton
{
    // Singleton
    class Logger
    {
        // Using Lazy<T>  to make instantiation process to be thread safe 
        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());
        //private static Logger? _instance;
        private Logger() { }

        // Singleton Instance
        public static Logger? Instance
        {
            get
            {
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;

                return _lazyLogger.Value;
            }
        }

        // Singleton Operation
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
