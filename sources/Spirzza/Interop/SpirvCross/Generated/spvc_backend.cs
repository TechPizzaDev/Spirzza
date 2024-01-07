namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend"]/*' />
public enum spvc_backend
{
    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_NONE"]/*' />
    SPVC_BACKEND_NONE = 0,

    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_GLSL"]/*' />
    SPVC_BACKEND_GLSL = 1,

    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_HLSL"]/*' />
    SPVC_BACKEND_HLSL = 2,

    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_MSL"]/*' />
    SPVC_BACKEND_MSL = 3,

    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_CPP"]/*' />
    SPVC_BACKEND_CPP = 4,

    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_JSON"]/*' />
    SPVC_BACKEND_JSON = 5,

    /// <include file='spvc_backend.xml' path='doc/member[@name="spvc_backend.SPVC_BACKEND_INT_MAX"]/*' />
    SPVC_BACKEND_INT_MAX = 0x7fffffff,
}
