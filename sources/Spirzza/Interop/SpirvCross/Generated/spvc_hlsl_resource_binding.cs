namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_hlsl_resource_binding
    {
        public SpvExecutionModel stage;

        [NativeTypeName("unsigned int")]
        public uint desc_set;

        [NativeTypeName("unsigned int")]
        public uint binding;

        public spvc_hlsl_resource_binding_mapping cbv;

        public spvc_hlsl_resource_binding_mapping uav;

        public spvc_hlsl_resource_binding_mapping srv;

        public spvc_hlsl_resource_binding_mapping sampler;
    }
}
