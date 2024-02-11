namespace DesignPrinciples.SOLID.DependencyInversionPrinciple.NotFollowing
{
    internal class DependecyInversionSolution
    {
        //Interface for logging
        public interface ILogger
        {
            void LogMessage(string message);
        }
        //Concrete Loggers
        public class ConsoleLogger : ILogger
        {
            public void LogMessage(string message)
            {
                Console.WriteLine(message);
            }
        }
        public class FileLogger : ILogger
        {
            private string _filePath;
            public FileLogger(string filePath)
            {
                _filePath = filePath;
            }
            public void LogMessage(string message)
            {
                // Just a simple example. In a real-world scenario, proper exception handling and file IO management is needed.
                File.AppendAllText(_filePath, message);
            }
        }

        //Now, our NotificationService should depend on the abstraction
        public class NotificationService
        {
            private ILogger _logger;
            public NotificationService(ILogger logger)
            {
                _logger = logger;
            }
            public void Notify(string message)
            {
                // ... some notification logic ...
                _logger.LogMessage(message);
            }
        }

        //Testing the Dependency Inversion Principle 
        public class Program
        {
            public static void Main()
            {
                //Now, when initializing the NotificationService, 
                //we can decide which logger to use:
                var consoleLogger = new ConsoleLogger();
                var notificationService1 = new NotificationService(consoleLogger);
                var fileLogger = new FileLogger("path_to_log_file.txt");
                var notificationService2 = new NotificationService(fileLogger);
                Console.ReadKey();
            }
        }
    }
}
