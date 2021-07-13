using System.IO;

namespace NapilnikTask4
{
    internal class FileLogWritter : ILogger
    {
        public Result WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
            return Result.success;
        }
    }
}