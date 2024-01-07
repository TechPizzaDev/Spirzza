namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask"]/*' />
public enum SpvMemoryAccessMask
{
    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessMaskNone"]/*' />
    SpvMemoryAccessMaskNone = 0,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessVolatileMask"]/*' />
    SpvMemoryAccessVolatileMask = 0x00000001,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessAlignedMask"]/*' />
    SpvMemoryAccessAlignedMask = 0x00000002,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessNontemporalMask"]/*' />
    SpvMemoryAccessNontemporalMask = 0x00000004,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessMakePointerAvailableMask"]/*' />
    SpvMemoryAccessMakePointerAvailableMask = 0x00000008,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessMakePointerAvailableKHRMask"]/*' />
    SpvMemoryAccessMakePointerAvailableKHRMask = 0x00000008,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessMakePointerVisibleMask"]/*' />
    SpvMemoryAccessMakePointerVisibleMask = 0x00000010,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessMakePointerVisibleKHRMask"]/*' />
    SpvMemoryAccessMakePointerVisibleKHRMask = 0x00000010,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessNonPrivatePointerMask"]/*' />
    SpvMemoryAccessNonPrivatePointerMask = 0x00000020,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessNonPrivatePointerKHRMask"]/*' />
    SpvMemoryAccessNonPrivatePointerKHRMask = 0x00000020,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessAliasScopeINTELMaskMask"]/*' />
    SpvMemoryAccessAliasScopeINTELMaskMask = 0x00010000,

    /// <include file='SpvMemoryAccessMask.xml' path='doc/member[@name="SpvMemoryAccessMask.SpvMemoryAccessNoAliasINTELMaskMask"]/*' />
    SpvMemoryAccessNoAliasINTELMaskMask = 0x00020000,
}
