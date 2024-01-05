using System;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.Shaderc
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate shaderc_include_result* shaderc_include_resolve_fn(void* user_data, [NativeTypeName("const char *")] sbyte* requested_source, int type, [NativeTypeName("const char *")] sbyte* requesting_source, [NativeTypeName("size_t")] UIntPtr include_depth);
}
