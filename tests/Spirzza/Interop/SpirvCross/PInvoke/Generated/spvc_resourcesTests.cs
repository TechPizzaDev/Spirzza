using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;

/// <summary>Provides validation of the <see cref="spvc_resources" /> struct.</summary>
public static unsafe partial class spvc_resourcesTests
{
    /// <summary>Validates that the <see cref="spvc_resources" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_resources>(), Is.EqualTo(sizeof(spvc_resources)));
    }

    /// <summary>Validates that the <see cref="spvc_resources" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_resources).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_resources" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(spvc_resources), Is.EqualTo(1));
    }
}
