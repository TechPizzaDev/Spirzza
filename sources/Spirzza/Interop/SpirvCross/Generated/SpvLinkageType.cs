namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvLinkageType.xml' path='doc/member[@name="SpvLinkageType"]/*' />
public enum SpvLinkageType
{
    /// <include file='SpvLinkageType.xml' path='doc/member[@name="SpvLinkageType.SpvLinkageTypeExport"]/*' />
    SpvLinkageTypeExport = 0,

    /// <include file='SpvLinkageType.xml' path='doc/member[@name="SpvLinkageType.SpvLinkageTypeImport"]/*' />
    SpvLinkageTypeImport = 1,

    /// <include file='SpvLinkageType.xml' path='doc/member[@name="SpvLinkageType.SpvLinkageTypeLinkOnceODR"]/*' />
    SpvLinkageTypeLinkOnceODR = 2,

    /// <include file='SpvLinkageType.xml' path='doc/member[@name="SpvLinkageType.SpvLinkageTypeMax"]/*' />
    SpvLinkageTypeMax = 0x7fffffff,
}
