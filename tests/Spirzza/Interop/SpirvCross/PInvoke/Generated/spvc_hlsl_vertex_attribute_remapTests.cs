using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_hlsl_vertex_attribute_remap" /> struct.</summary>
    public static unsafe partial class spvc_hlsl_vertex_attribute_remapTests
    {
        /// <summary>Validates that the <see cref="spvc_hlsl_vertex_attribute_remap" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_hlsl_vertex_attribute_remap>(), Is.EqualTo(sizeof(spvc_hlsl_vertex_attribute_remap)));
        }

        /// <summary>Validates that the <see cref="spvc_hlsl_vertex_attribute_remap" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_hlsl_vertex_attribute_remap).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_hlsl_vertex_attribute_remap" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(spvc_hlsl_vertex_attribute_remap), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(spvc_hlsl_vertex_attribute_remap), Is.EqualTo(8));
            }
        }
    }
}
