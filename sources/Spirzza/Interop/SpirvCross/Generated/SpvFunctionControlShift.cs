namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift"]/*' />
public enum SpvFunctionControlShift
{
    /// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift.SpvFunctionControlInlineShift"]/*' />
    SpvFunctionControlInlineShift = 0,

    /// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift.SpvFunctionControlDontInlineShift"]/*' />
    SpvFunctionControlDontInlineShift = 1,

    /// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift.SpvFunctionControlPureShift"]/*' />
    SpvFunctionControlPureShift = 2,

    /// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift.SpvFunctionControlConstShift"]/*' />
    SpvFunctionControlConstShift = 3,

    /// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift.SpvFunctionControlOptNoneINTELShift"]/*' />
    SpvFunctionControlOptNoneINTELShift = 16,

    /// <include file='SpvFunctionControlShift.xml' path='doc/member[@name="SpvFunctionControlShift.SpvFunctionControlMax"]/*' />
    SpvFunctionControlMax = 0x7fffffff,
}
