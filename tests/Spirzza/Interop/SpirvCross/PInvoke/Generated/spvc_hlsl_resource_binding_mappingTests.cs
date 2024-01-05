using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_hlsl_resource_binding_mapping" /> struct.</summary>
    public static unsafe partial class spvc_hlsl_resource_binding_mappingTests
    {
        /// <summary>Validates that the <see cref="spvc_hlsl_resource_binding_mapping" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_hlsl_resource_binding_mapping>(), Is.EqualTo(sizeof(spvc_hlsl_resource_binding_mapping)));
        }

        /// <summary>Validates that the <see cref="spvc_hlsl_resource_binding_mapping" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_hlsl_resource_binding_mapping).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_hlsl_resource_binding_mapping" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_hlsl_resource_binding_mapping), Is.EqualTo(8));
        }
    }
}
