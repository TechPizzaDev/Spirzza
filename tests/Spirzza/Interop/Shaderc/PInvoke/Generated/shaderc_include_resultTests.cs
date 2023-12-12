using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.Shaderc.UnitTests
{
    /// <summary>Provides validation of the <see cref="shaderc_include_result" /> struct.</summary>
    public static unsafe partial class shaderc_include_resultTests
    {
        /// <summary>Validates that the <see cref="shaderc_include_result" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<shaderc_include_result>(), Is.EqualTo(sizeof(shaderc_include_result)));
        }

        /// <summary>Validates that the <see cref="shaderc_include_result" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(shaderc_include_result).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="shaderc_include_result" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(shaderc_include_result), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(shaderc_include_result), Is.EqualTo(20));
            }
        }
    }
}
