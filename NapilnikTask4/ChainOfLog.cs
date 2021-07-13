using System;
using System.Collections.Generic;

namespace NapilnikTask4
{
    internal class ChainOfLog : ILogger
    {
        private readonly IEnumerable<ILogger> _loggers;

        public ChainOfLog(ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public static ChainOfLog Create(params ILogger[] loggers)
        {
            return new ChainOfLog(loggers);
        }

        public void WriteError(string message)
        {
            foreach (ILogger logger in _loggers)
            {
                logger.WriteError(message);
            }
        }

    }
}