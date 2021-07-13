using System;

namespace NapilnikTask4
{
    internal class ConsoleLogWritter : LogWritter, ILogger
    {
        public ConsoleLogWritter(ISecurePolicy scecurePolicy = null)
            : base(scecurePolicy)
        {
        }

        public override void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}