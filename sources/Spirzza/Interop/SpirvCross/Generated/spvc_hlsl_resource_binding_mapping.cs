namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_hlsl_resource_binding_mapping.xml' path='doc/member[@name="spvc_hlsl_resource_binding_mapping"]/*' />
public partial struct spvc_hlsl_resource_binding_mapping
{
    /// <include file='spvc_hlsl_resource_binding_mapping.xml' path='doc/member[@name="spvc_hlsl_resource_binding_mapping.register_space"]/*' />
    [NativeTypeName("unsigned int")]
    public uint register_space;

    /// <include file='spvc_hlsl_resource_binding_mapping.xml' path='doc/member[@name="spvc_hlsl_resource_binding_mapping.register_binding"]/*' />
    [NativeTypeName("unsigned int")]
    public uint register_binding;
}
