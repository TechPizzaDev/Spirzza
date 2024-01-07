namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute"]/*' />
public partial struct spvc_msl_vertex_attribute
{
    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.location"]/*' />
    [NativeTypeName("unsigned int")]
    public uint location;

    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.msl_buffer"]/*' />
    [NativeTypeName("unsigned int")]
    public uint msl_buffer;

    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.msl_offset"]/*' />
    [NativeTypeName("unsigned int")]
    public uint msl_offset;

    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.msl_stride"]/*' />
    [NativeTypeName("unsigned int")]
    public uint msl_stride;

    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.per_instance"]/*' />
    public spvc_bool per_instance;

    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.format"]/*' />
    [NativeTypeName("spvc_msl_vertex_format")]
    public spvc_msl_shader_variable_format format;

    /// <include file='spvc_msl_vertex_attribute.xml' path='doc/member[@name="spvc_msl_vertex_attribute.builtin"]/*' />
    public SpvBuiltIn builtin;
}
