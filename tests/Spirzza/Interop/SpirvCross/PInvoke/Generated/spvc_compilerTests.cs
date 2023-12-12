using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_compiler" /> struct.</summary>
    public static unsafe partial class spvc_compilerTests
    {
        /// <summary>Validates that the <see cref="spvc_compiler" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_compiler>(), Is.EqualTo(sizeof(spvc_compiler)));
        }

        /// <summary>Validates that the <see cref="spvc_compiler" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_compiler).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_compiler" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(spvc_compiler), Is.EqualTo(1));
        }
    }
}
