namespace Spirzza.Interop.SpirvCross
{
    public enum SpvMemoryAccessMask
    {
        SpvMemoryAccessMaskNone = 0,
        SpvMemoryAccessVolatileMask = 0x00000001,
        SpvMemoryAccessAlignedMask = 0x00000002,
        SpvMemoryAccessNontemporalMask = 0x00000004,
        SpvMemoryAccessMakePointerAvailableMask = 0x00000008,
        SpvMemoryAccessMakePointerAvailableKHRMask = 0x00000008,
        SpvMemoryAccessMakePointerVisibleMask = 0x00000010,
        SpvMemoryAccessMakePointerVisibleKHRMask = 0x00000010,
        SpvMemoryAccessNonPrivatePointerMask = 0x00000020,
        SpvMemoryAccessNonPrivatePointerKHRMask = 0x00000020,
    }
}
