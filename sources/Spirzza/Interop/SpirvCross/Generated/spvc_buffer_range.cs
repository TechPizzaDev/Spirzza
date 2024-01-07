namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_buffer_range.xml' path='doc/member[@name="spvc_buffer_range"]/*' />
public partial struct spvc_buffer_range
{
    /// <include file='spvc_buffer_range.xml' path='doc/member[@name="spvc_buffer_range.index"]/*' />
    [NativeTypeName("unsigned int")]
    public uint index;

    /// <include file='spvc_buffer_range.xml' path='doc/member[@name="spvc_buffer_range.offset"]/*' />
    [NativeTypeName("size_t")]
    public nuint offset;

    /// <include file='spvc_buffer_range.xml' path='doc/member[@name="spvc_buffer_range.range"]/*' />
    [NativeTypeName("size_t")]
    public nuint range;
}
