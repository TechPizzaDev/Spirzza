namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address"]/*' />
public enum spvc_msl_sampler_address
{
    /// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address.SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_ZERO"]/*' />
    SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_ZERO = 0,

    /// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address.SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE"]/*' />
    SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE = 1,

    /// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address.SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_BORDER"]/*' />
    SPVC_MSL_SAMPLER_ADDRESS_CLAMP_TO_BORDER = 2,

    /// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address.SPVC_MSL_SAMPLER_ADDRESS_REPEAT"]/*' />
    SPVC_MSL_SAMPLER_ADDRESS_REPEAT = 3,

    /// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address.SPVC_MSL_SAMPLER_ADDRESS_MIRRORED_REPEAT"]/*' />
    SPVC_MSL_SAMPLER_ADDRESS_MIRRORED_REPEAT = 4,

    /// <include file='spvc_msl_sampler_address.xml' path='doc/member[@name="spvc_msl_sampler_address.SPVC_MSL_SAMPLER_ADDRESS_INT_MAX"]/*' />
    SPVC_MSL_SAMPLER_ADDRESS_INT_MAX = 0x7fffffff,
}
