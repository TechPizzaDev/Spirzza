namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass"]/*' />
public enum SpvStorageClass
{
    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassUniformConstant"]/*' />
    SpvStorageClassUniformConstant = 0,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassInput"]/*' />
    SpvStorageClassInput = 1,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassUniform"]/*' />
    SpvStorageClassUniform = 2,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassOutput"]/*' />
    SpvStorageClassOutput = 3,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassWorkgroup"]/*' />
    SpvStorageClassWorkgroup = 4,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassCrossWorkgroup"]/*' />
    SpvStorageClassCrossWorkgroup = 5,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassPrivate"]/*' />
    SpvStorageClassPrivate = 6,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassFunction"]/*' />
    SpvStorageClassFunction = 7,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassGeneric"]/*' />
    SpvStorageClassGeneric = 8,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassPushConstant"]/*' />
    SpvStorageClassPushConstant = 9,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassAtomicCounter"]/*' />
    SpvStorageClassAtomicCounter = 10,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassImage"]/*' />
    SpvStorageClassImage = 11,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassStorageBuffer"]/*' />
    SpvStorageClassStorageBuffer = 12,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassCallableDataKHR"]/*' />
    SpvStorageClassCallableDataKHR = 5328,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassCallableDataNV"]/*' />
    SpvStorageClassCallableDataNV = 5328,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassIncomingCallableDataKHR"]/*' />
    SpvStorageClassIncomingCallableDataKHR = 5329,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassIncomingCallableDataNV"]/*' />
    SpvStorageClassIncomingCallableDataNV = 5329,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassRayPayloadKHR"]/*' />
    SpvStorageClassRayPayloadKHR = 5338,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassRayPayloadNV"]/*' />
    SpvStorageClassRayPayloadNV = 5338,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassHitAttributeKHR"]/*' />
    SpvStorageClassHitAttributeKHR = 5339,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassHitAttributeNV"]/*' />
    SpvStorageClassHitAttributeNV = 5339,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassIncomingRayPayloadKHR"]/*' />
    SpvStorageClassIncomingRayPayloadKHR = 5342,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassIncomingRayPayloadNV"]/*' />
    SpvStorageClassIncomingRayPayloadNV = 5342,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassShaderRecordBufferKHR"]/*' />
    SpvStorageClassShaderRecordBufferKHR = 5343,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassShaderRecordBufferNV"]/*' />
    SpvStorageClassShaderRecordBufferNV = 5343,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassPhysicalStorageBuffer"]/*' />
    SpvStorageClassPhysicalStorageBuffer = 5349,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassPhysicalStorageBufferEXT"]/*' />
    SpvStorageClassPhysicalStorageBufferEXT = 5349,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassTaskPayloadWorkgroupEXT"]/*' />
    SpvStorageClassTaskPayloadWorkgroupEXT = 5402,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassCodeSectionINTEL"]/*' />
    SpvStorageClassCodeSectionINTEL = 5605,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassDeviceOnlyINTEL"]/*' />
    SpvStorageClassDeviceOnlyINTEL = 5936,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassHostOnlyINTEL"]/*' />
    SpvStorageClassHostOnlyINTEL = 5937,

    /// <include file='SpvStorageClass.xml' path='doc/member[@name="SpvStorageClass.SpvStorageClassMax"]/*' />
    SpvStorageClassMax = 0x7fffffff,
}
