using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_compiler_options" /> struct.</summary>
    public static unsafe partial class spvc_compiler_optionsTests
    {
        /// <summary>Validates that the <see cref="spvc_compiler_options" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_compiler_options>(), Is.EqualTo(sizeof(spvc_compiler_options)));
        }

        /// <summary>Validates that the <see cref="spvc_compiler_options" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_compiler_options).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_compiler_options" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_compiler_options), Is.EqualTo(1));
        }
    }
}
