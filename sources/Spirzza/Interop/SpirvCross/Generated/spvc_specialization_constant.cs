namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_specialization_constant
    {
        public spvc_constant_id id;

        [NativeTypeName("unsigned int")]
        public uint constant_id;
    }
}
