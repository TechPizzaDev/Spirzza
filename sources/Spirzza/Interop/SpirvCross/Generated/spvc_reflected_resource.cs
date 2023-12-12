namespace Spirzza.Interop.SpirvCross
{
    public unsafe partial struct spvc_reflected_resource
    {
        public spvc_variable_id id;

        public spvc_type_id base_type_id;

        public spvc_type_id type_id;

        [NativeTypeName("const char *")]
        public sbyte* name;
    }
}
