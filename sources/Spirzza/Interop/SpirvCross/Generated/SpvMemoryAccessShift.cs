namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift"]/*' />
public enum SpvMemoryAccessShift
{
    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessVolatileShift"]/*' />
    SpvMemoryAccessVolatileShift = 0,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessAlignedShift"]/*' />
    SpvMemoryAccessAlignedShift = 1,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessNontemporalShift"]/*' />
    SpvMemoryAccessNontemporalShift = 2,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessMakePointerAvailableShift"]/*' />
    SpvMemoryAccessMakePointerAvailableShift = 3,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessMakePointerAvailableKHRShift"]/*' />
    SpvMemoryAccessMakePointerAvailableKHRShift = 3,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessMakePointerVisibleShift"]/*' />
    SpvMemoryAccessMakePointerVisibleShift = 4,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessMakePointerVisibleKHRShift"]/*' />
    SpvMemoryAccessMakePointerVisibleKHRShift = 4,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessNonPrivatePointerShift"]/*' />
    SpvMemoryAccessNonPrivatePointerShift = 5,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessNonPrivatePointerKHRShift"]/*' />
    SpvMemoryAccessNonPrivatePointerKHRShift = 5,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessAliasScopeINTELMaskShift"]/*' />
    SpvMemoryAccessAliasScopeINTELMaskShift = 16,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessNoAliasINTELMaskShift"]/*' />
    SpvMemoryAccessNoAliasINTELMaskShift = 17,

    /// <include file='SpvMemoryAccessShift.xml' path='doc/member[@name="SpvMemoryAccessShift.SpvMemoryAccessMax"]/*' />
    SpvMemoryAccessMax = 0x7fffffff,
}
