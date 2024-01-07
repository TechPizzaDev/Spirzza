namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_hlsl_vertex_attribute_remap.xml' path='doc/member[@name="spvc_hlsl_vertex_attribute_remap"]/*' />
public unsafe partial struct spvc_hlsl_vertex_attribute_remap
{
    /// <include file='spvc_hlsl_vertex_attribute_remap.xml' path='doc/member[@name="spvc_hlsl_vertex_attribute_remap.location"]/*' />
    [NativeTypeName("unsigned int")]
    public uint location;

    /// <include file='spvc_hlsl_vertex_attribute_remap.xml' path='doc/member[@name="spvc_hlsl_vertex_attribute_remap.semantic"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* semantic;
}
