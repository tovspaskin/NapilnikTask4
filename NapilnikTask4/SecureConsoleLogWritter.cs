using System;
using System.IO;

namespace NapilnikTask4
{
    internal class SecureConsoleLogWritter : ILogger
    {
        public Result WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return Result.success;
            }
            else
            {
                return Result.error;
            }
        }
    }
}