using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void spvc_error_callback(void* userdata, [NativeTypeName("const char *")] sbyte* error);
}
