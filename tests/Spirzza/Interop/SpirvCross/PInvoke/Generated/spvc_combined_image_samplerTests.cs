using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_combined_image_sampler" /> struct.</summary>
    public static unsafe partial class spvc_combined_image_samplerTests
    {
        /// <summary>Validates that the <see cref="spvc_combined_image_sampler" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_combined_image_sampler>(), Is.EqualTo(sizeof(spvc_combined_image_sampler)));
        }

        /// <summary>Validates that the <see cref="spvc_combined_image_sampler" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_combined_image_sampler).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_combined_image_sampler" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_combined_image_sampler), Is.EqualTo(12));
        }
    }
}
