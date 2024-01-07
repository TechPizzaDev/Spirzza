namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_entry_point.xml' path='doc/member[@name="spvc_entry_point"]/*' />
public unsafe partial struct spvc_entry_point
{
    /// <include file='spvc_entry_point.xml' path='doc/member[@name="spvc_entry_point.execution_model"]/*' />
    public SpvExecutionModel execution_model;

    /// <include file='spvc_entry_point.xml' path='doc/member[@name="spvc_entry_point.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;
}
