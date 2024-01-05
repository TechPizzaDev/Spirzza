using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.Shaderc.UnitTests
{
    /// <summary>Provides validation of the <see cref="shaderc_compile_options" /> struct.</summary>
    public static unsafe partial class shaderc_compile_optionsTests
    {
        /// <summary>Validates that the <see cref="shaderc_compile_options" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<shaderc_compile_options>(), Is.EqualTo(sizeof(shaderc_compile_options)));
        }

        /// <summary>Validates that the <see cref="shaderc_compile_options" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(shaderc_compile_options).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="shaderc_compile_options" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(shaderc_compile_options), Is.EqualTo(1));
        }
    }
}
