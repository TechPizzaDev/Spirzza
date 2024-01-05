using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.Shaderc.UnitTests
{
    /// <summary>Provides validation of the <see cref="shaderc_compiler" /> struct.</summary>
    public static unsafe partial class shaderc_compilerTests
    {
        /// <summary>Validates that the <see cref="shaderc_compiler" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<shaderc_compiler>(), Is.EqualTo(sizeof(shaderc_compiler)));
        }

        /// <summary>Validates that the <see cref="shaderc_compiler" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(shaderc_compiler).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="shaderc_compiler" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(shaderc_compiler), Is.EqualTo(1));
        }
    }
}
