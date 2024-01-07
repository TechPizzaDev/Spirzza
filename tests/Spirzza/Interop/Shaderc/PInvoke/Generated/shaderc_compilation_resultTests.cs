using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Spirzza.Interop.Shaderc.UnitTests;

/// <summary>Provides validation of the <see cref="shaderc_compilation_result" /> struct.</summary>
public static unsafe partial class shaderc_compilation_resultTests
{
    /// <summary>Validates that the <see cref="shaderc_compilation_result" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<shaderc_compilation_result>(), Is.EqualTo(sizeof(shaderc_compilation_result)));
    }

    /// <summary>Validates that the <see cref="shaderc_compilation_result" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(shaderc_compilation_result).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="shaderc_compilation_result" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(shaderc_compilation_result), Is.EqualTo(1));
    }
}
