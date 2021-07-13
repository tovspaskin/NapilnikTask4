using System.IO;

namespace NapilnikTask4
{
    internal class Pathfinder
    {
        private const string FindSuccess = "Findind is success.";
        private const string NotFindError = "Error: File do not find.";
        private readonly ILogger _logger;

        public Pathfinder(ILogger logger)
        {
            _logger = logger;
        }

        public void Find(string path)
        {
            if (File.Exists(path))
            {
                _logger.Write(FindSuccess);
            }
            else
            {
               _logger.Write(NotFindError);
            }
        }
    }
}