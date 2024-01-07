namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvFPDenormMode.xml' path='doc/member[@name="SpvFPDenormMode"]/*' />
public enum SpvFPDenormMode
{
    /// <include file='SpvFPDenormMode.xml' path='doc/member[@name="SpvFPDenormMode.SpvFPDenormModePreserve"]/*' />
    SpvFPDenormModePreserve = 0,

    /// <include file='SpvFPDenormMode.xml' path='doc/member[@name="SpvFPDenormMode.SpvFPDenormModeFlushToZero"]/*' />
    SpvFPDenormModeFlushToZero = 1,

    /// <include file='SpvFPDenormMode.xml' path='doc/member[@name="SpvFPDenormMode.SpvFPDenormModeMax"]/*' />
    SpvFPDenormModeMax = 0x7fffffff,
}
