using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_msl_resource_binding" /> struct.</summary>
    public static unsafe partial class spvc_msl_resource_bindingTests
    {
        /// <summary>Validates that the <see cref="spvc_msl_resource_binding" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_msl_resource_binding>(), Is.EqualTo(sizeof(spvc_msl_resource_binding)));
        }

        /// <summary>Validates that the <see cref="spvc_msl_resource_binding" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_msl_resource_binding).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_msl_resource_binding" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_msl_resource_binding), Is.EqualTo(24));
        }
    }
}
