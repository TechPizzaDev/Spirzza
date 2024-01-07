namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_specialization_constant.xml' path='doc/member[@name="spvc_specialization_constant"]/*' />
public partial struct spvc_specialization_constant
{
    /// <include file='spvc_specialization_constant.xml' path='doc/member[@name="spvc_specialization_constant.id"]/*' />
    public spvc_constant_id id;

    /// <include file='spvc_specialization_constant.xml' path='doc/member[@name="spvc_specialization_constant.constant_id"]/*' />
    [NativeTypeName("unsigned int")]
    public uint constant_id;
}
