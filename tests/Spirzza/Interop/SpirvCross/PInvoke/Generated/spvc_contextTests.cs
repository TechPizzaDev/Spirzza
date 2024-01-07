using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;

/// <summary>Provides validation of the <see cref="spvc_context" /> struct.</summary>
public static unsafe partial class spvc_contextTests
{
    /// <summary>Validates that the <see cref="spvc_context" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_context>(), Is.EqualTo(sizeof(spvc_context)));
    }

    /// <summary>Validates that the <see cref="spvc_context" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_context).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_context" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(spvc_context), Is.EqualTo(1));
    }
}
