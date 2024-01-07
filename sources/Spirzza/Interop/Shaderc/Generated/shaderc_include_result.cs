namespace Spirzza.Interop.Shaderc;

/// <include file='shaderc_include_result.xml' path='doc/member[@name="shaderc_include_result"]/*' />
public unsafe partial struct shaderc_include_result
{
    /// <include file='shaderc_include_result.xml' path='doc/member[@name="shaderc_include_result.source_name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* source_name;

    /// <include file='shaderc_include_result.xml' path='doc/member[@name="shaderc_include_result.source_name_length"]/*' />
    [NativeTypeName("size_t")]
    public nuint source_name_length;

    /// <include file='shaderc_include_result.xml' path='doc/member[@name="shaderc_include_result.content"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* content;

    /// <include file='shaderc_include_result.xml' path='doc/member[@name="shaderc_include_result.content_length"]/*' />
    [NativeTypeName("size_t")]
    public nuint content_length;

    /// <include file='shaderc_include_result.xml' path='doc/member[@name="shaderc_include_result.user_data"]/*' />
    public void* user_data;
}
