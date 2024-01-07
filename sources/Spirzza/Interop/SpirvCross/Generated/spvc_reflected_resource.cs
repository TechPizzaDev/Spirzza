namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_reflected_resource.xml' path='doc/member[@name="spvc_reflected_resource"]/*' />
public unsafe partial struct spvc_reflected_resource
{
    /// <include file='spvc_reflected_resource.xml' path='doc/member[@name="spvc_reflected_resource.id"]/*' />
    public spvc_variable_id id;

    /// <include file='spvc_reflected_resource.xml' path='doc/member[@name="spvc_reflected_resource.base_type_id"]/*' />
    public spvc_type_id base_type_id;

    /// <include file='spvc_reflected_resource.xml' path='doc/member[@name="spvc_reflected_resource.type_id"]/*' />
    public spvc_type_id type_id;

    /// <include file='spvc_reflected_resource.xml' path='doc/member[@name="spvc_reflected_resource.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;
}
