using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;

/// <summary>Provides validation of the <see cref="spvc_buffer_range" /> struct.</summary>
public static unsafe partial class spvc_buffer_rangeTests
{
    /// <summary>Validates that the <see cref="spvc_buffer_range" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_buffer_range>(), Is.EqualTo(sizeof(spvc_buffer_range)));
    }

    /// <summary>Validates that the <see cref="spvc_buffer_range" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_buffer_range).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_buffer_range" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(spvc_buffer_range), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(spvc_buffer_range), Is.EqualTo(12));
        }
    }
}
