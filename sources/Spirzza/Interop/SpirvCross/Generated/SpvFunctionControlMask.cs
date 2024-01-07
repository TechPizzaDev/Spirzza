namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask"]/*' />
public enum SpvFunctionControlMask
{
    /// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask.SpvFunctionControlMaskNone"]/*' />
    SpvFunctionControlMaskNone = 0,

    /// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask.SpvFunctionControlInlineMask"]/*' />
    SpvFunctionControlInlineMask = 0x00000001,

    /// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask.SpvFunctionControlDontInlineMask"]/*' />
    SpvFunctionControlDontInlineMask = 0x00000002,

    /// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask.SpvFunctionControlPureMask"]/*' />
    SpvFunctionControlPureMask = 0x00000004,

    /// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask.SpvFunctionControlConstMask"]/*' />
    SpvFunctionControlConstMask = 0x00000008,

    /// <include file='SpvFunctionControlMask.xml' path='doc/member[@name="SpvFunctionControlMask.SpvFunctionControlOptNoneINTELMask"]/*' />
    SpvFunctionControlOptNoneINTELMask = 0x00010000,
}
