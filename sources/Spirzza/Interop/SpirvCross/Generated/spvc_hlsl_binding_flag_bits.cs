namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits"]/*' />
public enum spvc_hlsl_binding_flag_bits
{
    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_NONE_BIT"]/*' />
    SPVC_HLSL_BINDING_AUTO_NONE_BIT = 0,

    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT"]/*' />
    SPVC_HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT = 1 << 0,

    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_CBV_BIT"]/*' />
    SPVC_HLSL_BINDING_AUTO_CBV_BIT = 1 << 1,

    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_SRV_BIT"]/*' />
    SPVC_HLSL_BINDING_AUTO_SRV_BIT = 1 << 2,

    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_UAV_BIT"]/*' />
    SPVC_HLSL_BINDING_AUTO_UAV_BIT = 1 << 3,

    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_SAMPLER_BIT"]/*' />
    SPVC_HLSL_BINDING_AUTO_SAMPLER_BIT = 1 << 4,

    /// <include file='spvc_hlsl_binding_flag_bits.xml' path='doc/member[@name="spvc_hlsl_binding_flag_bits.SPVC_HLSL_BINDING_AUTO_ALL"]/*' />
    SPVC_HLSL_BINDING_AUTO_ALL = 0x7fffffff,
}
