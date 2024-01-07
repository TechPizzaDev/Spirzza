namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask"]/*' />
public enum SpvMemorySemanticsMask
{
    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsMaskNone"]/*' />
    SpvMemorySemanticsMaskNone = 0,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsAcquireMask"]/*' />
    SpvMemorySemanticsAcquireMask = 0x00000002,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsReleaseMask"]/*' />
    SpvMemorySemanticsReleaseMask = 0x00000004,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsAcquireReleaseMask"]/*' />
    SpvMemorySemanticsAcquireReleaseMask = 0x00000008,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsSequentiallyConsistentMask"]/*' />
    SpvMemorySemanticsSequentiallyConsistentMask = 0x00000010,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsUniformMemoryMask"]/*' />
    SpvMemorySemanticsUniformMemoryMask = 0x00000040,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsSubgroupMemoryMask"]/*' />
    SpvMemorySemanticsSubgroupMemoryMask = 0x00000080,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsWorkgroupMemoryMask"]/*' />
    SpvMemorySemanticsWorkgroupMemoryMask = 0x00000100,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsCrossWorkgroupMemoryMask"]/*' />
    SpvMemorySemanticsCrossWorkgroupMemoryMask = 0x00000200,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsAtomicCounterMemoryMask"]/*' />
    SpvMemorySemanticsAtomicCounterMemoryMask = 0x00000400,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsImageMemoryMask"]/*' />
    SpvMemorySemanticsImageMemoryMask = 0x00000800,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsOutputMemoryMask"]/*' />
    SpvMemorySemanticsOutputMemoryMask = 0x00001000,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsOutputMemoryKHRMask"]/*' />
    SpvMemorySemanticsOutputMemoryKHRMask = 0x00001000,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsMakeAvailableMask"]/*' />
    SpvMemorySemanticsMakeAvailableMask = 0x00002000,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsMakeAvailableKHRMask"]/*' />
    SpvMemorySemanticsMakeAvailableKHRMask = 0x00002000,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsMakeVisibleMask"]/*' />
    SpvMemorySemanticsMakeVisibleMask = 0x00004000,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsMakeVisibleKHRMask"]/*' />
    SpvMemorySemanticsMakeVisibleKHRMask = 0x00004000,

    /// <include file='SpvMemorySemanticsMask.xml' path='doc/member[@name="SpvMemorySemanticsMask.SpvMemorySemanticsVolatileMask"]/*' />
    SpvMemorySemanticsVolatileMask = 0x00008000,
}
