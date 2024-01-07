namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask"]/*' />
public enum SpvFPFastMathModeMask
{
    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeMaskNone"]/*' />
    SpvFPFastMathModeMaskNone = 0,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeNotNaNMask"]/*' />
    SpvFPFastMathModeNotNaNMask = 0x00000001,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeNotInfMask"]/*' />
    SpvFPFastMathModeNotInfMask = 0x00000002,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeNSZMask"]/*' />
    SpvFPFastMathModeNSZMask = 0x00000004,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeAllowRecipMask"]/*' />
    SpvFPFastMathModeAllowRecipMask = 0x00000008,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeFastMask"]/*' />
    SpvFPFastMathModeFastMask = 0x00000010,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeAllowContractFastINTELMask"]/*' />
    SpvFPFastMathModeAllowContractFastINTELMask = 0x00010000,

    /// <include file='SpvFPFastMathModeMask.xml' path='doc/member[@name="SpvFPFastMathModeMask.SpvFPFastMathModeAllowReassocINTELMask"]/*' />
    SpvFPFastMathModeAllowReassocINTELMask = 0x00020000,
}
