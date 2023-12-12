using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_parsed_ir" /> struct.</summary>
    public static unsafe partial class spvc_parsed_irTests
    {
        /// <summary>Validates that the <see cref="spvc_parsed_ir" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_parsed_ir>(), Is.EqualTo(sizeof(spvc_parsed_ir)));
        }

        /// <summary>Validates that the <see cref="spvc_parsed_ir" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_parsed_ir).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_parsed_ir" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_parsed_ir), Is.EqualTo(1));
        }
    }
}
