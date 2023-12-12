namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_msl_resource_binding
    {
        public SpvExecutionModel stage;

        [NativeTypeName("unsigned int")]
        public uint desc_set;

        [NativeTypeName("unsigned int")]
        public uint binding;

        [NativeTypeName("unsigned int")]
        public uint msl_buffer;

        [NativeTypeName("unsigned int")]
        public uint msl_texture;

        [NativeTypeName("unsigned int")]
        public uint msl_sampler;
    }
}
