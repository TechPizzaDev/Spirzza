namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask"]/*' />
public enum SpvLoopControlMask
{
    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlMaskNone"]/*' />
    SpvLoopControlMaskNone = 0,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlUnrollMask"]/*' />
    SpvLoopControlUnrollMask = 0x00000001,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlDontUnrollMask"]/*' />
    SpvLoopControlDontUnrollMask = 0x00000002,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlDependencyInfiniteMask"]/*' />
    SpvLoopControlDependencyInfiniteMask = 0x00000004,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlDependencyLengthMask"]/*' />
    SpvLoopControlDependencyLengthMask = 0x00000008,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlMinIterationsMask"]/*' />
    SpvLoopControlMinIterationsMask = 0x00000010,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlMaxIterationsMask"]/*' />
    SpvLoopControlMaxIterationsMask = 0x00000020,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlIterationMultipleMask"]/*' />
    SpvLoopControlIterationMultipleMask = 0x00000040,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlPeelCountMask"]/*' />
    SpvLoopControlPeelCountMask = 0x00000080,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlPartialCountMask"]/*' />
    SpvLoopControlPartialCountMask = 0x00000100,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlInitiationIntervalINTELMask"]/*' />
    SpvLoopControlInitiationIntervalINTELMask = 0x00010000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlMaxConcurrencyINTELMask"]/*' />
    SpvLoopControlMaxConcurrencyINTELMask = 0x00020000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlDependencyArrayINTELMask"]/*' />
    SpvLoopControlDependencyArrayINTELMask = 0x00040000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlPipelineEnableINTELMask"]/*' />
    SpvLoopControlPipelineEnableINTELMask = 0x00080000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlLoopCoalesceINTELMask"]/*' />
    SpvLoopControlLoopCoalesceINTELMask = 0x00100000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlMaxInterleavingINTELMask"]/*' />
    SpvLoopControlMaxInterleavingINTELMask = 0x00200000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlSpeculatedIterationsINTELMask"]/*' />
    SpvLoopControlSpeculatedIterationsINTELMask = 0x00400000,

    /// <include file='SpvLoopControlMask.xml' path='doc/member[@name="SpvLoopControlMask.SpvLoopControlNoFusionINTELMask"]/*' />
    SpvLoopControlNoFusionINTELMask = 0x00800000,
}
