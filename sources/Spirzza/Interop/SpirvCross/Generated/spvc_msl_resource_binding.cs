namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding"]/*' />
public partial struct spvc_msl_resource_binding
{
    /// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding.stage"]/*' />
    public SpvExecutionModel stage;

    /// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding.desc_set"]/*' />
    [NativeTypeName("unsigned int")]
    public uint desc_set;

    /// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding.binding"]/*' />
    [NativeTypeName("unsigned int")]
    public uint binding;

    /// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding.msl_buffer"]/*' />
    [NativeTypeName("unsigned int")]
    public uint msl_buffer;

    /// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding.msl_texture"]/*' />
    [NativeTypeName("unsigned int")]
    public uint msl_texture;

    /// <include file='spvc_msl_resource_binding.xml' path='doc/member[@name="spvc_msl_resource_binding.msl_sampler"]/*' />
    [NativeTypeName("unsigned int")]
    public uint msl_sampler;
}
