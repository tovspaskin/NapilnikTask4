using System;
using System.IO;

namespace NapilnikTask4
{
    internal class SecureOnlyFriday : ISecurePolicy
    {
        public bool CanWrite()
        {
            return DateTime.Now.DayOfWeek == DayOfWeek.Friday;
        }
    }
}