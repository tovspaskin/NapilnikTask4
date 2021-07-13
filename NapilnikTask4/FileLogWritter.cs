using System.IO;

namespace NapilnikTask4
{
    internal class FileLogWritter : ILogStrategy
    {
        public bool WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
            return true;
        }
    }
}