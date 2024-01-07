namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode"]/*' />
public enum SpvExecutionMode
{
    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeInvocations"]/*' />
    SpvExecutionModeInvocations = 0,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSpacingEqual"]/*' />
    SpvExecutionModeSpacingEqual = 1,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSpacingFractionalEven"]/*' />
    SpvExecutionModeSpacingFractionalEven = 2,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSpacingFractionalOdd"]/*' />
    SpvExecutionModeSpacingFractionalOdd = 3,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeVertexOrderCw"]/*' />
    SpvExecutionModeVertexOrderCw = 4,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeVertexOrderCcw"]/*' />
    SpvExecutionModeVertexOrderCcw = 5,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModePixelCenterInteger"]/*' />
    SpvExecutionModePixelCenterInteger = 6,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOriginUpperLeft"]/*' />
    SpvExecutionModeOriginUpperLeft = 7,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOriginLowerLeft"]/*' />
    SpvExecutionModeOriginLowerLeft = 8,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeEarlyFragmentTests"]/*' />
    SpvExecutionModeEarlyFragmentTests = 9,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModePointMode"]/*' />
    SpvExecutionModePointMode = 10,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeXfb"]/*' />
    SpvExecutionModeXfb = 11,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDepthReplacing"]/*' />
    SpvExecutionModeDepthReplacing = 12,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDepthGreater"]/*' />
    SpvExecutionModeDepthGreater = 14,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDepthLess"]/*' />
    SpvExecutionModeDepthLess = 15,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDepthUnchanged"]/*' />
    SpvExecutionModeDepthUnchanged = 16,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeLocalSize"]/*' />
    SpvExecutionModeLocalSize = 17,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeLocalSizeHint"]/*' />
    SpvExecutionModeLocalSizeHint = 18,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeInputPoints"]/*' />
    SpvExecutionModeInputPoints = 19,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeInputLines"]/*' />
    SpvExecutionModeInputLines = 20,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeInputLinesAdjacency"]/*' />
    SpvExecutionModeInputLinesAdjacency = 21,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeTriangles"]/*' />
    SpvExecutionModeTriangles = 22,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeInputTrianglesAdjacency"]/*' />
    SpvExecutionModeInputTrianglesAdjacency = 23,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeQuads"]/*' />
    SpvExecutionModeQuads = 24,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeIsolines"]/*' />
    SpvExecutionModeIsolines = 25,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputVertices"]/*' />
    SpvExecutionModeOutputVertices = 26,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputPoints"]/*' />
    SpvExecutionModeOutputPoints = 27,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputLineStrip"]/*' />
    SpvExecutionModeOutputLineStrip = 28,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputTriangleStrip"]/*' />
    SpvExecutionModeOutputTriangleStrip = 29,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeVecTypeHint"]/*' />
    SpvExecutionModeVecTypeHint = 30,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeContractionOff"]/*' />
    SpvExecutionModeContractionOff = 31,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeInitializer"]/*' />
    SpvExecutionModeInitializer = 33,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeFinalizer"]/*' />
    SpvExecutionModeFinalizer = 34,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSubgroupSize"]/*' />
    SpvExecutionModeSubgroupSize = 35,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSubgroupsPerWorkgroup"]/*' />
    SpvExecutionModeSubgroupsPerWorkgroup = 36,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSubgroupsPerWorkgroupId"]/*' />
    SpvExecutionModeSubgroupsPerWorkgroupId = 37,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeLocalSizeId"]/*' />
    SpvExecutionModeLocalSizeId = 38,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeLocalSizeHintId"]/*' />
    SpvExecutionModeLocalSizeHintId = 39,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSubgroupUniformControlFlowKHR"]/*' />
    SpvExecutionModeSubgroupUniformControlFlowKHR = 4421,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModePostDepthCoverage"]/*' />
    SpvExecutionModePostDepthCoverage = 4446,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDenormPreserve"]/*' />
    SpvExecutionModeDenormPreserve = 4459,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDenormFlushToZero"]/*' />
    SpvExecutionModeDenormFlushToZero = 4460,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSignedZeroInfNanPreserve"]/*' />
    SpvExecutionModeSignedZeroInfNanPreserve = 4461,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeRoundingModeRTE"]/*' />
    SpvExecutionModeRoundingModeRTE = 4462,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeRoundingModeRTZ"]/*' />
    SpvExecutionModeRoundingModeRTZ = 4463,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeEarlyAndLateFragmentTestsAMD"]/*' />
    SpvExecutionModeEarlyAndLateFragmentTestsAMD = 5017,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefReplacingEXT"]/*' />
    SpvExecutionModeStencilRefReplacingEXT = 5027,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefUnchangedFrontAMD"]/*' />
    SpvExecutionModeStencilRefUnchangedFrontAMD = 5079,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefGreaterFrontAMD"]/*' />
    SpvExecutionModeStencilRefGreaterFrontAMD = 5080,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefLessFrontAMD"]/*' />
    SpvExecutionModeStencilRefLessFrontAMD = 5081,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefUnchangedBackAMD"]/*' />
    SpvExecutionModeStencilRefUnchangedBackAMD = 5082,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefGreaterBackAMD"]/*' />
    SpvExecutionModeStencilRefGreaterBackAMD = 5083,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeStencilRefLessBackAMD"]/*' />
    SpvExecutionModeStencilRefLessBackAMD = 5084,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputLinesEXT"]/*' />
    SpvExecutionModeOutputLinesEXT = 5269,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputLinesNV"]/*' />
    SpvExecutionModeOutputLinesNV = 5269,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputPrimitivesEXT"]/*' />
    SpvExecutionModeOutputPrimitivesEXT = 5270,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputPrimitivesNV"]/*' />
    SpvExecutionModeOutputPrimitivesNV = 5270,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDerivativeGroupQuadsNV"]/*' />
    SpvExecutionModeDerivativeGroupQuadsNV = 5289,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeDerivativeGroupLinearNV"]/*' />
    SpvExecutionModeDerivativeGroupLinearNV = 5290,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputTrianglesEXT"]/*' />
    SpvExecutionModeOutputTrianglesEXT = 5298,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeOutputTrianglesNV"]/*' />
    SpvExecutionModeOutputTrianglesNV = 5298,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModePixelInterlockOrderedEXT"]/*' />
    SpvExecutionModePixelInterlockOrderedEXT = 5366,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModePixelInterlockUnorderedEXT"]/*' />
    SpvExecutionModePixelInterlockUnorderedEXT = 5367,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSampleInterlockOrderedEXT"]/*' />
    SpvExecutionModeSampleInterlockOrderedEXT = 5368,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSampleInterlockUnorderedEXT"]/*' />
    SpvExecutionModeSampleInterlockUnorderedEXT = 5369,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeShadingRateInterlockOrderedEXT"]/*' />
    SpvExecutionModeShadingRateInterlockOrderedEXT = 5370,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeShadingRateInterlockUnorderedEXT"]/*' />
    SpvExecutionModeShadingRateInterlockUnorderedEXT = 5371,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSharedLocalMemorySizeINTEL"]/*' />
    SpvExecutionModeSharedLocalMemorySizeINTEL = 5618,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeRoundingModeRTPINTEL"]/*' />
    SpvExecutionModeRoundingModeRTPINTEL = 5620,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeRoundingModeRTNINTEL"]/*' />
    SpvExecutionModeRoundingModeRTNINTEL = 5621,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeFloatingPointModeALTINTEL"]/*' />
    SpvExecutionModeFloatingPointModeALTINTEL = 5622,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeFloatingPointModeIEEEINTEL"]/*' />
    SpvExecutionModeFloatingPointModeIEEEINTEL = 5623,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeMaxWorkgroupSizeINTEL"]/*' />
    SpvExecutionModeMaxWorkgroupSizeINTEL = 5893,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeMaxWorkDimINTEL"]/*' />
    SpvExecutionModeMaxWorkDimINTEL = 5894,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeNoGlobalOffsetINTEL"]/*' />
    SpvExecutionModeNoGlobalOffsetINTEL = 5895,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeNumSIMDWorkitemsINTEL"]/*' />
    SpvExecutionModeNumSIMDWorkitemsINTEL = 5896,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeSchedulerTargetFmaxMhzINTEL"]/*' />
    SpvExecutionModeSchedulerTargetFmaxMhzINTEL = 5903,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeNamedBarrierCountINTEL"]/*' />
    SpvExecutionModeNamedBarrierCountINTEL = 6417,

    /// <include file='SpvExecutionMode.xml' path='doc/member[@name="SpvExecutionMode.SpvExecutionModeMax"]/*' />
    SpvExecutionModeMax = 0x7fffffff,
}
