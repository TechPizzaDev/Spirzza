namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format"]/*' />
public enum spvc_msl_shader_variable_format
{
    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_VARIABLE_FORMAT_OTHER"]/*' />
    SPVC_MSL_SHADER_VARIABLE_FORMAT_OTHER = 0,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT8"]/*' />
    SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT8 = 1,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT16"]/*' />
    SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT16 = 2,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY16"]/*' />
    SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY16 = 3,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY32"]/*' />
    SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY32 = 4,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_VERTEX_FORMAT_OTHER"]/*' />
    SPVC_MSL_VERTEX_FORMAT_OTHER = SPVC_MSL_SHADER_VARIABLE_FORMAT_OTHER,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_VERTEX_FORMAT_UINT8"]/*' />
    SPVC_MSL_VERTEX_FORMAT_UINT8 = SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT8,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_VERTEX_FORMAT_UINT16"]/*' />
    SPVC_MSL_VERTEX_FORMAT_UINT16 = SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT16,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_INPUT_FORMAT_OTHER"]/*' />
    SPVC_MSL_SHADER_INPUT_FORMAT_OTHER = SPVC_MSL_SHADER_VARIABLE_FORMAT_OTHER,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_INPUT_FORMAT_UINT8"]/*' />
    SPVC_MSL_SHADER_INPUT_FORMAT_UINT8 = SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT8,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_INPUT_FORMAT_UINT16"]/*' />
    SPVC_MSL_SHADER_INPUT_FORMAT_UINT16 = SPVC_MSL_SHADER_VARIABLE_FORMAT_UINT16,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_INPUT_FORMAT_ANY16"]/*' />
    SPVC_MSL_SHADER_INPUT_FORMAT_ANY16 = SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY16,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_INPUT_FORMAT_ANY32"]/*' />
    SPVC_MSL_SHADER_INPUT_FORMAT_ANY32 = SPVC_MSL_SHADER_VARIABLE_FORMAT_ANY32,

    /// <include file='spvc_msl_shader_variable_format.xml' path='doc/member[@name="spvc_msl_shader_variable_format.SPVC_MSL_SHADER_INPUT_FORMAT_INT_MAX"]/*' />
    SPVC_MSL_SHADER_INPUT_FORMAT_INT_MAX = 0x7fffffff,
}
