using System;
using System.IO;

namespace NapilnikTask4
{
    internal class SecureConsoleLogWritter : ILogStrategy
    {
        public bool WriteError(string message)
        {
            return DateTime.Now.DayOfWeek == DayOfWeek.Friday;
        }
    }
}