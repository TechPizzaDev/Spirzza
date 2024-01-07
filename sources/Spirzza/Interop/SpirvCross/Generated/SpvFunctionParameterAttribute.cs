namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute"]/*' />
public enum SpvFunctionParameterAttribute
{
    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeZext"]/*' />
    SpvFunctionParameterAttributeZext = 0,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeSext"]/*' />
    SpvFunctionParameterAttributeSext = 1,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeByVal"]/*' />
    SpvFunctionParameterAttributeByVal = 2,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeSret"]/*' />
    SpvFunctionParameterAttributeSret = 3,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeNoAlias"]/*' />
    SpvFunctionParameterAttributeNoAlias = 4,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeNoCapture"]/*' />
    SpvFunctionParameterAttributeNoCapture = 5,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeNoWrite"]/*' />
    SpvFunctionParameterAttributeNoWrite = 6,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeNoReadWrite"]/*' />
    SpvFunctionParameterAttributeNoReadWrite = 7,

    /// <include file='SpvFunctionParameterAttribute.xml' path='doc/member[@name="SpvFunctionParameterAttribute.SpvFunctionParameterAttributeMax"]/*' />
    SpvFunctionParameterAttributeMax = 0x7fffffff,
}
