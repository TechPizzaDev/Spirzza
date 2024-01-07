namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_msl_shader_input
    {
        [NativeTypeName("unsigned int")]
        public uint location;

        [NativeTypeName("spvc_msl_vertex_format")]
        public spvc_msl_shader_input_format format;

        public SpvBuiltIn builtin;

        [NativeTypeName("unsigned int")]
        public uint vecsize;
    }
}
