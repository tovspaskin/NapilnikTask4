using System;

namespace NapilnikTask4
{
    internal class ConsoleLogWritter : ILogger
    {
        public Result WriteError(string message)
        {
            Console.WriteLine(message);
            return Result.success;
        }
    }
}