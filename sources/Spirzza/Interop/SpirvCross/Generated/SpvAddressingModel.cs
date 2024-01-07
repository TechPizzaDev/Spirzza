namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel"]/*' />
public enum SpvAddressingModel
{
    /// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel.SpvAddressingModelLogical"]/*' />
    SpvAddressingModelLogical = 0,

    /// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel.SpvAddressingModelPhysical32"]/*' />
    SpvAddressingModelPhysical32 = 1,

    /// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel.SpvAddressingModelPhysical64"]/*' />
    SpvAddressingModelPhysical64 = 2,

    /// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel.SpvAddressingModelPhysicalStorageBuffer64"]/*' />
    SpvAddressingModelPhysicalStorageBuffer64 = 5348,

    /// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel.SpvAddressingModelPhysicalStorageBuffer64EXT"]/*' />
    SpvAddressingModelPhysicalStorageBuffer64EXT = 5348,

    /// <include file='SpvAddressingModel.xml' path='doc/member[@name="SpvAddressingModel.SpvAddressingModelMax"]/*' />
    SpvAddressingModelMax = 0x7fffffff,
}
