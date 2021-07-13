using System;
using System.IO;

namespace NapilnikTask4
{
    internal class SecureSimple : ISecurePolicy
    {
        public bool CanWrite()
        {
            return true;
        }
    }
}