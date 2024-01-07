namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvKernelEnqueueFlags.xml' path='doc/member[@name="SpvKernelEnqueueFlags"]/*' />
public enum SpvKernelEnqueueFlags
{
    /// <include file='SpvKernelEnqueueFlags.xml' path='doc/member[@name="SpvKernelEnqueueFlags.SpvKernelEnqueueFlagsNoWait"]/*' />
    SpvKernelEnqueueFlagsNoWait = 0,

    /// <include file='SpvKernelEnqueueFlags.xml' path='doc/member[@name="SpvKernelEnqueueFlags.SpvKernelEnqueueFlagsWaitKernel"]/*' />
    SpvKernelEnqueueFlagsWaitKernel = 1,

    /// <include file='SpvKernelEnqueueFlags.xml' path='doc/member[@name="SpvKernelEnqueueFlags.SpvKernelEnqueueFlagsWaitWorkGroup"]/*' />
    SpvKernelEnqueueFlagsWaitWorkGroup = 2,

    /// <include file='SpvKernelEnqueueFlags.xml' path='doc/member[@name="SpvKernelEnqueueFlags.SpvKernelEnqueueFlagsMax"]/*' />
    SpvKernelEnqueueFlagsMax = 0x7fffffff,
}
