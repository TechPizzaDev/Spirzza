namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvAccessQualifier.xml' path='doc/member[@name="SpvAccessQualifier"]/*' />
public enum SpvAccessQualifier
{
    /// <include file='SpvAccessQualifier.xml' path='doc/member[@name="SpvAccessQualifier.SpvAccessQualifierReadOnly"]/*' />
    SpvAccessQualifierReadOnly = 0,

    /// <include file='SpvAccessQualifier.xml' path='doc/member[@name="SpvAccessQualifier.SpvAccessQualifierWriteOnly"]/*' />
    SpvAccessQualifierWriteOnly = 1,

    /// <include file='SpvAccessQualifier.xml' path='doc/member[@name="SpvAccessQualifier.SpvAccessQualifierReadWrite"]/*' />
    SpvAccessQualifierReadWrite = 2,

    /// <include file='SpvAccessQualifier.xml' path='doc/member[@name="SpvAccessQualifier.SpvAccessQualifierMax"]/*' />
    SpvAccessQualifierMax = 0x7fffffff,
}
