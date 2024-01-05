namespace Spirzza.Interop.SpirvCross
{
    public enum SpvKernelEnqueueFlags
    {
        SpvKernelEnqueueFlagsNoWait = 0,
        SpvKernelEnqueueFlagsWaitKernel = 1,
        SpvKernelEnqueueFlagsWaitWorkGroup = 2,
        SpvKernelEnqueueFlagsMax = 0x7fffffff,
    }
}
