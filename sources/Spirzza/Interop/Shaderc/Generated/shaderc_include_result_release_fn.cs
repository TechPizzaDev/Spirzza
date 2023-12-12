using System.Runtime.InteropServices;

namespace Spirzza.Interop.Shaderc
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void shaderc_include_result_release_fn(void* user_data, shaderc_include_result* include_result);
}
