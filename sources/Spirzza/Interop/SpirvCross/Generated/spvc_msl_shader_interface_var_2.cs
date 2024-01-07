namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_shader_interface_var_2.xml' path='doc/member[@name="spvc_msl_shader_interface_var_2"]/*' />
public partial struct spvc_msl_shader_interface_var_2
{
    /// <include file='spvc_msl_shader_interface_var_2.xml' path='doc/member[@name="spvc_msl_shader_interface_var_2.location"]/*' />
    [NativeTypeName("unsigned int")]
    public uint location;

    /// <include file='spvc_msl_shader_interface_var_2.xml' path='doc/member[@name="spvc_msl_shader_interface_var_2.format"]/*' />
    public spvc_msl_shader_variable_format format;

    /// <include file='spvc_msl_shader_interface_var_2.xml' path='doc/member[@name="spvc_msl_shader_interface_var_2.builtin"]/*' />
    public SpvBuiltIn builtin;

    /// <include file='spvc_msl_shader_interface_var_2.xml' path='doc/member[@name="spvc_msl_shader_interface_var_2.vecsize"]/*' />
    [NativeTypeName("unsigned int")]
    public uint vecsize;

    /// <include file='spvc_msl_shader_interface_var_2.xml' path='doc/member[@name="spvc_msl_shader_interface_var_2.rate"]/*' />
    public spvc_msl_shader_variable_rate rate;
}
