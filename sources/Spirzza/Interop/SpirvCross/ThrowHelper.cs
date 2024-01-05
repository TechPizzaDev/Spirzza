using System;
using System.Diagnostics.CodeAnalysis;

namespace Spirzza.Interop.SpirvCross;

internal static class ThrowHelper
{
    [DoesNotReturn]
    internal static void ThrowIndexOutOfRangeException()
    {
        throw new IndexOutOfRangeException();
    }
}
