using System;

namespace NapilnikTask4
{
    internal class Log : ILogger
    {
        private readonly ILogStrategy _logStrategy;
        private readonly ILogger _logger;

        public Log(ILogStrategy logStrategy, ILogger logger = null)
        {
            _logStrategy = logStrategy;
            _logger = logger;
        }

        public void Write(string message)
        {
            bool success = _logStrategy?.WriteError(message) ?? throw new ArgumentNullException();
            if (success)
            {
                _logger?.Write(message);
            }
        }
    }
}