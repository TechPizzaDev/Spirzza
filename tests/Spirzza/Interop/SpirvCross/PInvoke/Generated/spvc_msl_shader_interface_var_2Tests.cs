using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross.UnitTests;

/// <summary>Provides validation of the <see cref="spvc_msl_shader_interface_var_2" /> struct.</summary>
public static unsafe partial class spvc_msl_shader_interface_var_2Tests
{
    /// <summary>Validates that the <see cref="spvc_msl_shader_interface_var_2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<spvc_msl_shader_interface_var_2>(), Is.EqualTo(sizeof(spvc_msl_shader_interface_var_2)));
    }

    /// <summary>Validates that the <see cref="spvc_msl_shader_interface_var_2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(spvc_msl_shader_interface_var_2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="spvc_msl_shader_interface_var_2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(spvc_msl_shader_interface_var_2), Is.EqualTo(20));
    }
}
