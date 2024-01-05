using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests
{
    /// <summary>Provides validation of the <see cref="spvc_entry_point" /> struct.</summary>
    public static unsafe partial class spvc_entry_pointTests
    {
        /// <summary>Validates that the <see cref="spvc_entry_point" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<spvc_entry_point>(), Is.EqualTo(sizeof(spvc_entry_point)));
        }

        /// <summary>Validates that the <see cref="spvc_entry_point" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(spvc_entry_point).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="spvc_entry_point" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(spvc_entry_point), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(spvc_entry_point), Is.EqualTo(8));
            }
        }
    }
}
