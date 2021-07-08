using System;
using System.IO;

namespace NapilnikTask4
{
    internal class SecureConsoleLogWritter : ILogger
    {
        private readonly ILogger _logger;

        public SecureConsoleLogWritter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                _logger.WriteError(message);
            }
        }
    }
}