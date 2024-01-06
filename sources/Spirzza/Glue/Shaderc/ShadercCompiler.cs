using System;
using System.Runtime.InteropServices;
using Spirzza.Interop.Shaderc;
using static Spirzza.Interop.Shaderc.Shaderc;

namespace Spirzza.Glue.Shaderc;

public sealed unsafe class ShadercCompiler : SafeHandle
{
    public ShadercCompiler(shaderc_compiler* handle, bool ownsHandle) : base((IntPtr) handle, ownsHandle)
    {
    }

    public ShadercCompiler() : this(CreateHandle(), true)
    {
    }

    public override bool IsInvalid => handle == IntPtr.Zero;

    private static shaderc_compiler* CreateHandle()
    {
        shaderc_compiler* handle = shaderc_compiler_initialize();
        if (handle == null)
        {
            throw new ShadercException("Failed to create ", null);
        }
        return handle;
    }

    internal void DangerousAddRef()
    {
        bool success = false;
        DangerousAddRef(ref success);
    }

    public new shaderc_compiler* DangerousGetHandle()
    {
        return (shaderc_compiler*) base.DangerousGetHandle();
    }

    //public SpirvModule CompileToSpirv(
    //    SourceProvider sourceProvider,
    //    string sourceFileName,
    //    string entryPoint)
    //{
    //}

    protected override bool ReleaseHandle()
    {
        shaderc_compiler_release((shaderc_compiler*) handle);
        return true;
    }
}