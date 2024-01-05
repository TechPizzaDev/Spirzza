namespace Spirzza.Interop.SpirvCross
{
    public unsafe partial struct spvc_entry_point
    {
        public SpvExecutionModel execution_model;

        [NativeTypeName("const char *")]
        public sbyte* name;
    }
}
