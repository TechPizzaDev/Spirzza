namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_result.xml' path='doc/member[@name="spvc_result"]/*' />
public enum spvc_result
{
    /// <include file='spvc_result.xml' path='doc/member[@name="spvc_result.SPVC_SUCCESS"]/*' />
    SPVC_SUCCESS = 0,

    /// <include file='spvc_result.xml' path='doc/member[@name="spvc_result.SPVC_ERROR_INVALID_SPIRV"]/*' />
    SPVC_ERROR_INVALID_SPIRV = -1,

    /// <include file='spvc_result.xml' path='doc/member[@name="spvc_result.SPVC_ERROR_UNSUPPORTED_SPIRV"]/*' />
    SPVC_ERROR_UNSUPPORTED_SPIRV = -2,

    /// <include file='spvc_result.xml' path='doc/member[@name="spvc_result.SPVC_ERROR_OUT_OF_MEMORY"]/*' />
    SPVC_ERROR_OUT_OF_MEMORY = -3,

    /// <include file='spvc_result.xml' path='doc/member[@name="spvc_result.SPVC_ERROR_INVALID_ARGUMENT"]/*' />
    SPVC_ERROR_INVALID_ARGUMENT = -4,

    /// <include file='spvc_result.xml' path='doc/member[@name="spvc_result.SPVC_ERROR_INT_MAX"]/*' />
    SPVC_ERROR_INT_MAX = 0x7fffffff,
}
