namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask"]/*' />
public enum SpvRayFlagsMask
{
    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsMaskNone"]/*' />
    SpvRayFlagsMaskNone = 0,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsOpaqueKHRMask"]/*' />
    SpvRayFlagsOpaqueKHRMask = 0x00000001,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsNoOpaqueKHRMask"]/*' />
    SpvRayFlagsNoOpaqueKHRMask = 0x00000002,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsTerminateOnFirstHitKHRMask"]/*' />
    SpvRayFlagsTerminateOnFirstHitKHRMask = 0x00000004,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsSkipClosestHitShaderKHRMask"]/*' />
    SpvRayFlagsSkipClosestHitShaderKHRMask = 0x00000008,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsCullBackFacingTrianglesKHRMask"]/*' />
    SpvRayFlagsCullBackFacingTrianglesKHRMask = 0x00000010,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsCullFrontFacingTrianglesKHRMask"]/*' />
    SpvRayFlagsCullFrontFacingTrianglesKHRMask = 0x00000020,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsCullOpaqueKHRMask"]/*' />
    SpvRayFlagsCullOpaqueKHRMask = 0x00000040,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsCullNoOpaqueKHRMask"]/*' />
    SpvRayFlagsCullNoOpaqueKHRMask = 0x00000080,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsSkipTrianglesKHRMask"]/*' />
    SpvRayFlagsSkipTrianglesKHRMask = 0x00000100,

    /// <include file='SpvRayFlagsMask.xml' path='doc/member[@name="SpvRayFlagsMask.SpvRayFlagsSkipAABBsKHRMask"]/*' />
    SpvRayFlagsSkipAABBsKHRMask = 0x00000200,
}
