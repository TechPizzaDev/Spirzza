using System;
using System.Runtime.Serialization;

namespace Spirzza.Glue.SpirvCross
{
#if !NET8_0_OR_GREATER
    [Serializable]
#endif
    public class SpirvCrossException : Exception
    {
        public SpirvCrossException()
        {
        }

        public SpirvCrossException(string? message) : base(message)
        {
        }

#if NET5_0_OR_GREATER
        [System.Text.Json.Serialization.JsonConstructor]
#endif
        public SpirvCrossException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

#if !NET8_0_OR_GREATER
        protected SpirvCrossException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
#endif
    }
}
