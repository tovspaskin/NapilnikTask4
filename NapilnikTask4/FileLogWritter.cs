using System.IO;

namespace NapilnikTask4
{
    internal class FileLogWritter : ILogger
    {
        private readonly ILogger _logger;

        public FileLogWritter()
        {
        }

        public FileLogWritter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
            _logger?.WriteError(message);
        }
    }
}