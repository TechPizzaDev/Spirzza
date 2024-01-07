namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding"]/*' />
public partial struct spvc_hlsl_resource_binding
{
    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.stage"]/*' />
    public SpvExecutionModel stage;

    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.desc_set"]/*' />
    [NativeTypeName("unsigned int")]
    public uint desc_set;

    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.binding"]/*' />
    [NativeTypeName("unsigned int")]
    public uint binding;

    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.cbv"]/*' />
    public spvc_hlsl_resource_binding_mapping cbv;

    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.uav"]/*' />
    public spvc_hlsl_resource_binding_mapping uav;

    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.srv"]/*' />
    public spvc_hlsl_resource_binding_mapping srv;

    /// <include file='spvc_hlsl_resource_binding.xml' path='doc/member[@name="spvc_hlsl_resource_binding.sampler"]/*' />
    public spvc_hlsl_resource_binding_mapping sampler;
}
