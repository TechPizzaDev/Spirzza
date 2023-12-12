using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_reflected_resource" /> struct.</summary>
    public static unsafe partial class spvc_reflected_resourceTests
    {
        /// <summary>Validates that the <see cref="spvc_reflected_resource" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_reflected_resource>(), Is.EqualTo(sizeof(spvc_reflected_resource)));
        }

        /// <summary>Validates that the <see cref="spvc_reflected_resource" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_reflected_resource).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_reflected_resource" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(spvc_reflected_resource), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(spvc_reflected_resource), Is.EqualTo(16));
            }
        }
    }
}
