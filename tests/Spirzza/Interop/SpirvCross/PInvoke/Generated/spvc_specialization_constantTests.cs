using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_specialization_constant" /> struct.</summary>
    public static unsafe partial class spvc_specialization_constantTests
    {
        /// <summary>Validates that the <see cref="spvc_specialization_constant" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_specialization_constant>(), Is.EqualTo(sizeof(spvc_specialization_constant)));
        }

        /// <summary>Validates that the <see cref="spvc_specialization_constant" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_specialization_constant).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_specialization_constant" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_specialization_constant), Is.EqualTo(8));
        }
    }
}
