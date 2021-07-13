using System;

namespace NapilnikTask4
{
    internal abstract class LogWritter : ILogger
    {
        private ISecurePolicy _securePolicy;

        public LogWritter(ISecurePolicy scecurePolicy = null)
        {
            _securePolicy = scecurePolicy ?? new SecureSimple();
        }

        public void WriteError(string message)
        {
            if (_securePolicy == null)
            {
                throw new ArgumentNullException("secure policy");
            }

            if (!_securePolicy.CanWrite())
            {
                throw new NotImplementedException();
            }

            Write(message);
        }

        public abstract void Write(string message);
    }
}