using System;

namespace NapilnikTask4
{
    internal class ConsoleLogWritter : ILogStrategy
    {
        public bool WriteError(string message)
        {
            Console.WriteLine(message);
            return true;
        }
    }
}