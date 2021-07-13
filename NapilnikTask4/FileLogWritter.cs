using System.IO;

namespace NapilnikTask4
{
    internal class FileLogWritter : LogWritter, ILogger
    {
        public FileLogWritter(ISecurePolicy securePolicy = null)
            : base(securePolicy)
        {
        }

        public override void Write(string message)
        {
            File.WriteAllText("log.txt", message);
        }
    }
}