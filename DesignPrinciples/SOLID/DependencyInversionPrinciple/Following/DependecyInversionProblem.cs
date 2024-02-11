namespace DesignPrinciples.SOLID.DependencyInversionPrinciple.Following
{
    internal class DependecyInversionProblem
    {
        // Not following DIP
        public class ConsoleLogger
        {
            public void LogMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class NotificationService
        {
            private ConsoleLogger _logger;

            public NotificationService()
            {
                _logger = new ConsoleLogger();
            }

            public void Notify(string message)
            {
                // ... some notification logic ...
                _logger.LogMessage(message);
            }
        }
    }
}
