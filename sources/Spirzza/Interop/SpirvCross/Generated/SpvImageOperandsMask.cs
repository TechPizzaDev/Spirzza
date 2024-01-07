namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask"]/*' />
public enum SpvImageOperandsMask
{
    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsMaskNone"]/*' />
    SpvImageOperandsMaskNone = 0,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsBiasMask"]/*' />
    SpvImageOperandsBiasMask = 0x00000001,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsLodMask"]/*' />
    SpvImageOperandsLodMask = 0x00000002,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsGradMask"]/*' />
    SpvImageOperandsGradMask = 0x00000004,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsConstOffsetMask"]/*' />
    SpvImageOperandsConstOffsetMask = 0x00000008,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsOffsetMask"]/*' />
    SpvImageOperandsOffsetMask = 0x00000010,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsConstOffsetsMask"]/*' />
    SpvImageOperandsConstOffsetsMask = 0x00000020,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsSampleMask"]/*' />
    SpvImageOperandsSampleMask = 0x00000040,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsMinLodMask"]/*' />
    SpvImageOperandsMinLodMask = 0x00000080,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsMakeTexelAvailableMask"]/*' />
    SpvImageOperandsMakeTexelAvailableMask = 0x00000100,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsMakeTexelAvailableKHRMask"]/*' />
    SpvImageOperandsMakeTexelAvailableKHRMask = 0x00000100,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsMakeTexelVisibleMask"]/*' />
    SpvImageOperandsMakeTexelVisibleMask = 0x00000200,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsMakeTexelVisibleKHRMask"]/*' />
    SpvImageOperandsMakeTexelVisibleKHRMask = 0x00000200,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsNonPrivateTexelMask"]/*' />
    SpvImageOperandsNonPrivateTexelMask = 0x00000400,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsNonPrivateTexelKHRMask"]/*' />
    SpvImageOperandsNonPrivateTexelKHRMask = 0x00000400,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsVolatileTexelMask"]/*' />
    SpvImageOperandsVolatileTexelMask = 0x00000800,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsVolatileTexelKHRMask"]/*' />
    SpvImageOperandsVolatileTexelKHRMask = 0x00000800,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsSignExtendMask"]/*' />
    SpvImageOperandsSignExtendMask = 0x00001000,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsZeroExtendMask"]/*' />
    SpvImageOperandsZeroExtendMask = 0x00002000,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsNontemporalMask"]/*' />
    SpvImageOperandsNontemporalMask = 0x00004000,

    /// <include file='SpvImageOperandsMask.xml' path='doc/member[@name="SpvImageOperandsMask.SpvImageOperandsOffsetsMask"]/*' />
    SpvImageOperandsOffsetsMask = 0x00010000,
}
