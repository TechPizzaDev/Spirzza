using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross
{
    public partial struct spvc_msl_sampler_ycbcr_conversion
    {
        [NativeTypeName("unsigned int")]
        public uint planes;

        public spvc_msl_format_resolution resolution;

        public spvc_msl_sampler_filter chroma_filter;

        public spvc_msl_chroma_location x_chroma_offset;

        public spvc_msl_chroma_location y_chroma_offset;

        [NativeTypeName("spvc_msl_component_swizzle[4]")]
        public _swizzle_e__FixedBuffer swizzle;

        public spvc_msl_sampler_ycbcr_model_conversion ycbcr_model;

        public spvc_msl_sampler_ycbcr_range ycbcr_range;

        [NativeTypeName("unsigned int")]
        public uint bpc;

        public partial struct _swizzle_e__FixedBuffer
        {
            public spvc_msl_component_swizzle e0;
            public spvc_msl_component_swizzle e1;
            public spvc_msl_component_swizzle e2;
            public spvc_msl_component_swizzle e3;

#if NETSTANDARD2_0
            [UnscopedRef]
            public ref spvc_msl_component_swizzle this[int index]
            {
                get
                {
                    switch (index)
                    {
                        case 0: return ref e0;
                        case 1: return ref e1;
                        case 2: return ref e2;
                        case 3: return ref e3;
                        default: 
                            ThrowHelper.ThrowIndexOutOfRangeException();
                            return ref e0;
                    }
                }
            }
#else
            [UnscopedRef]
            public ref spvc_msl_component_swizzle this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }
            
            [UnscopedRef]
            public Span<spvc_msl_component_swizzle> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
#endif
        }
    }
}
