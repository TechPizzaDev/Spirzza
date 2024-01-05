using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_msl_sampler_ycbcr_conversion" /> struct.</summary>
    public static unsafe partial class spvc_msl_sampler_ycbcr_conversionTests
    {
        /// <summary>Validates that the <see cref="spvc_msl_sampler_ycbcr_conversion" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_msl_sampler_ycbcr_conversion>(), Is.EqualTo(sizeof(spvc_msl_sampler_ycbcr_conversion)));
        }

        /// <summary>Validates that the <see cref="spvc_msl_sampler_ycbcr_conversion" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_msl_sampler_ycbcr_conversion).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_msl_sampler_ycbcr_conversion" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_msl_sampler_ycbcr_conversion), Is.EqualTo(48));
        }
    }
}
