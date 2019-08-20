using System;

namespace consoleappliation
{
    class Singleton
    {
        LazyLogger logger = LazyLogger.GetInstance;

        public void Print(string log)
        {
            logger.PrintLog(log);
        }
    }

    public sealed class Logger
    {
        private static Logger logger = null;
        private static object _object = new object();
        private Logger()
        {}

        //Get the instance of the Logger class
        public static Logger GetInstance
        {
            get
            {
                if(logger == null)
                {
                    lock (_object)
                    {
                        if (logger == null)
                        {
                            logger = new Logger();
                        }
                    }
                }
                return logger;
            }
        }

        //Print the log
        public void PrintLog(string log)
        {
            Console.WriteLine($"{DateTime.Now} - {log}");
        }
    }

    public sealed class LazyLogger
    {
        //Lazy is thread safety by default.Lazy is the keyword to use it.
        private static readonly Lazy<LazyLogger> logger = new Lazy<LazyLogger>(()=> new LazyLogger());
        private LazyLogger()
        {
        }

        public static LazyLogger GetInstance
        {
            get
            {
                return logger.Value;
            }
        }

        //Print the log
        public void PrintLog(string log)
        {
            Console.WriteLine($"{DateTime.Now} - {log}");
        }
    }
}
