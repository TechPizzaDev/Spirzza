using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;

/// <summary>Provides validation of the <see cref="spvc_constant" /> struct.</summary>
public static unsafe partial class spvc_constantTests
{
    /// <summary>Validates that the <see cref="spvc_constant" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_constant>(), Is.EqualTo(sizeof(spvc_constant)));
    }

    /// <summary>Validates that the <see cref="spvc_constant" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_constant).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_constant" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(spvc_constant), Is.EqualTo(1));
    }
}
