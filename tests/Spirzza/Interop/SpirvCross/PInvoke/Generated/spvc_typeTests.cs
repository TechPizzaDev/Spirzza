using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;

/// <summary>Provides validation of the <see cref="spvc_type" /> struct.</summary>
public static unsafe partial class spvc_typeTests
{
    /// <summary>Validates that the <see cref="spvc_type" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_type>(), Is.EqualTo(sizeof(spvc_type)));
    }

    /// <summary>Validates that the <see cref="spvc_type" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_type).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_type" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(spvc_type), Is.EqualTo(1));
    }
}
