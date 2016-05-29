using Bridge;

namespace System
{
    [External]
    public class InvalidCastException : Exception, IBridgeClass
    {
        public extern InvalidCastException();

        public extern InvalidCastException(string message);

        public extern InvalidCastException(string message, Exception innerException);
    }
}