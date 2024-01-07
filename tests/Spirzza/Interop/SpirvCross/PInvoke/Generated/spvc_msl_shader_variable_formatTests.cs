using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;


/// <summary>Provides validation of the <see cref="spvc_msl_shader_variable_format" /> struct.</summary>
public static unsafe partial class spvc_msl_shader_variable_formatTests
{
    /// <summary>Validates that the <see cref="spvc_msl_shader_variable_format" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_msl_shader_variable_format>(), Is.EqualTo(sizeof(spvc_msl_shader_variable_format)));
    }

    /// <summary>Validates that the <see cref="spvc_msl_shader_variable_format" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_msl_shader_variable_format).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_msl_shader_variable_format" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(spvc_msl_shader_variable_format), Is.EqualTo(16));
    }
}
