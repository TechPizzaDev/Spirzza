namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_shader_interface_var.xml' path='doc/member[@name="spvc_msl_shader_interface_var"]/*' />
public partial struct spvc_msl_shader_interface_var
{
    /// <include file='spvc_msl_shader_interface_var.xml' path='doc/member[@name="spvc_msl_shader_interface_var.location"]/*' />
    [NativeTypeName("unsigned int")]
    public uint location;

    /// <include file='spvc_msl_shader_interface_var.xml' path='doc/member[@name="spvc_msl_shader_interface_var.format"]/*' />
    [NativeTypeName("spvc_msl_vertex_format")]
    public spvc_msl_shader_variable_format format;

    /// <include file='spvc_msl_shader_interface_var.xml' path='doc/member[@name="spvc_msl_shader_interface_var.builtin"]/*' />
    public SpvBuiltIn builtin;

    /// <include file='spvc_msl_shader_interface_var.xml' path='doc/member[@name="spvc_msl_shader_interface_var.vecsize"]/*' />
    [NativeTypeName("unsigned int")]
    public uint vecsize;
}
