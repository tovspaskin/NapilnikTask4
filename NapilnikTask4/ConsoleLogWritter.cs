using System;

namespace NapilnikTask4
{
    internal class ConsoleLogWritter : ILogger
    {
        private readonly ILogger _logger;

        public ConsoleLogWritter()
        {
        }

        public ConsoleLogWritter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            Console.WriteLine(message);
            _logger?.WriteError(message);
        }
    }
}