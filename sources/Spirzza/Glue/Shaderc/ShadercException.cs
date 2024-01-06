using System;
using System.Runtime.Serialization;

namespace Spirzza.Glue.Shaderc
{
#if !NET8_0_OR_GREATER
    [Serializable]
#endif
    public class ShadercException : Exception
    {
        public ShadercException()
        {
        }

        public ShadercException(string? message) : base(message)
        {
        }

#if NET5_0_OR_GREATER
        [System.Text.Json.Serialization.JsonConstructor]
#endif
        public ShadercException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

#if !NET8_0_OR_GREATER
        protected ShadercException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}
