namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvOp.xml' path='doc/member[@name="SpvOp"]/*' />
public enum SpvOp
{
    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpNop"]/*' />
    SpvOpNop = 0,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUndef"]/*' />
    SpvOpUndef = 1,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSourceContinued"]/*' />
    SpvOpSourceContinued = 2,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSource"]/*' />
    SpvOpSource = 3,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSourceExtension"]/*' />
    SpvOpSourceExtension = 4,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpName"]/*' />
    SpvOpName = 5,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemberName"]/*' />
    SpvOpMemberName = 6,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpString"]/*' />
    SpvOpString = 7,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLine"]/*' />
    SpvOpLine = 8,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExtension"]/*' />
    SpvOpExtension = 10,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExtInstImport"]/*' />
    SpvOpExtInstImport = 11,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExtInst"]/*' />
    SpvOpExtInst = 12,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemoryModel"]/*' />
    SpvOpMemoryModel = 14,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEntryPoint"]/*' />
    SpvOpEntryPoint = 15,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExecutionMode"]/*' />
    SpvOpExecutionMode = 16,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCapability"]/*' />
    SpvOpCapability = 17,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeVoid"]/*' />
    SpvOpTypeVoid = 19,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeBool"]/*' />
    SpvOpTypeBool = 20,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeInt"]/*' />
    SpvOpTypeInt = 21,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeFloat"]/*' />
    SpvOpTypeFloat = 22,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeVector"]/*' />
    SpvOpTypeVector = 23,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeMatrix"]/*' />
    SpvOpTypeMatrix = 24,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeImage"]/*' />
    SpvOpTypeImage = 25,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeSampler"]/*' />
    SpvOpTypeSampler = 26,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeSampledImage"]/*' />
    SpvOpTypeSampledImage = 27,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeArray"]/*' />
    SpvOpTypeArray = 28,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeRuntimeArray"]/*' />
    SpvOpTypeRuntimeArray = 29,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeStruct"]/*' />
    SpvOpTypeStruct = 30,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeOpaque"]/*' />
    SpvOpTypeOpaque = 31,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypePointer"]/*' />
    SpvOpTypePointer = 32,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeFunction"]/*' />
    SpvOpTypeFunction = 33,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeEvent"]/*' />
    SpvOpTypeEvent = 34,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeDeviceEvent"]/*' />
    SpvOpTypeDeviceEvent = 35,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeReserveId"]/*' />
    SpvOpTypeReserveId = 36,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeQueue"]/*' />
    SpvOpTypeQueue = 37,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypePipe"]/*' />
    SpvOpTypePipe = 38,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeForwardPointer"]/*' />
    SpvOpTypeForwardPointer = 39,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantTrue"]/*' />
    SpvOpConstantTrue = 41,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantFalse"]/*' />
    SpvOpConstantFalse = 42,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstant"]/*' />
    SpvOpConstant = 43,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantComposite"]/*' />
    SpvOpConstantComposite = 44,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantSampler"]/*' />
    SpvOpConstantSampler = 45,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantNull"]/*' />
    SpvOpConstantNull = 46,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSpecConstantTrue"]/*' />
    SpvOpSpecConstantTrue = 48,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSpecConstantFalse"]/*' />
    SpvOpSpecConstantFalse = 49,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSpecConstant"]/*' />
    SpvOpSpecConstant = 50,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSpecConstantComposite"]/*' />
    SpvOpSpecConstantComposite = 51,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSpecConstantOp"]/*' />
    SpvOpSpecConstantOp = 52,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFunction"]/*' />
    SpvOpFunction = 54,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFunctionParameter"]/*' />
    SpvOpFunctionParameter = 55,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFunctionEnd"]/*' />
    SpvOpFunctionEnd = 56,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFunctionCall"]/*' />
    SpvOpFunctionCall = 57,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVariable"]/*' />
    SpvOpVariable = 59,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageTexelPointer"]/*' />
    SpvOpImageTexelPointer = 60,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLoad"]/*' />
    SpvOpLoad = 61,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpStore"]/*' />
    SpvOpStore = 62,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCopyMemory"]/*' />
    SpvOpCopyMemory = 63,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCopyMemorySized"]/*' />
    SpvOpCopyMemorySized = 64,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAccessChain"]/*' />
    SpvOpAccessChain = 65,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpInBoundsAccessChain"]/*' />
    SpvOpInBoundsAccessChain = 66,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPtrAccessChain"]/*' />
    SpvOpPtrAccessChain = 67,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArrayLength"]/*' />
    SpvOpArrayLength = 68,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGenericPtrMemSemantics"]/*' />
    SpvOpGenericPtrMemSemantics = 69,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpInBoundsPtrAccessChain"]/*' />
    SpvOpInBoundsPtrAccessChain = 70,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDecorate"]/*' />
    SpvOpDecorate = 71,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemberDecorate"]/*' />
    SpvOpMemberDecorate = 72,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDecorationGroup"]/*' />
    SpvOpDecorationGroup = 73,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupDecorate"]/*' />
    SpvOpGroupDecorate = 74,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupMemberDecorate"]/*' />
    SpvOpGroupMemberDecorate = 75,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVectorExtractDynamic"]/*' />
    SpvOpVectorExtractDynamic = 77,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVectorInsertDynamic"]/*' />
    SpvOpVectorInsertDynamic = 78,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVectorShuffle"]/*' />
    SpvOpVectorShuffle = 79,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCompositeConstruct"]/*' />
    SpvOpCompositeConstruct = 80,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCompositeExtract"]/*' />
    SpvOpCompositeExtract = 81,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCompositeInsert"]/*' />
    SpvOpCompositeInsert = 82,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCopyObject"]/*' />
    SpvOpCopyObject = 83,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTranspose"]/*' />
    SpvOpTranspose = 84,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSampledImage"]/*' />
    SpvOpSampledImage = 86,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleImplicitLod"]/*' />
    SpvOpImageSampleImplicitLod = 87,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleExplicitLod"]/*' />
    SpvOpImageSampleExplicitLod = 88,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleDrefImplicitLod"]/*' />
    SpvOpImageSampleDrefImplicitLod = 89,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleDrefExplicitLod"]/*' />
    SpvOpImageSampleDrefExplicitLod = 90,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleProjImplicitLod"]/*' />
    SpvOpImageSampleProjImplicitLod = 91,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleProjExplicitLod"]/*' />
    SpvOpImageSampleProjExplicitLod = 92,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleProjDrefImplicitLod"]/*' />
    SpvOpImageSampleProjDrefImplicitLod = 93,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleProjDrefExplicitLod"]/*' />
    SpvOpImageSampleProjDrefExplicitLod = 94,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageFetch"]/*' />
    SpvOpImageFetch = 95,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageGather"]/*' />
    SpvOpImageGather = 96,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageDrefGather"]/*' />
    SpvOpImageDrefGather = 97,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageRead"]/*' />
    SpvOpImageRead = 98,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageWrite"]/*' />
    SpvOpImageWrite = 99,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImage"]/*' />
    SpvOpImage = 100,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQueryFormat"]/*' />
    SpvOpImageQueryFormat = 101,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQueryOrder"]/*' />
    SpvOpImageQueryOrder = 102,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQuerySizeLod"]/*' />
    SpvOpImageQuerySizeLod = 103,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQuerySize"]/*' />
    SpvOpImageQuerySize = 104,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQueryLod"]/*' />
    SpvOpImageQueryLod = 105,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQueryLevels"]/*' />
    SpvOpImageQueryLevels = 106,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageQuerySamples"]/*' />
    SpvOpImageQuerySamples = 107,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertFToU"]/*' />
    SpvOpConvertFToU = 109,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertFToS"]/*' />
    SpvOpConvertFToS = 110,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertSToF"]/*' />
    SpvOpConvertSToF = 111,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertUToF"]/*' />
    SpvOpConvertUToF = 112,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUConvert"]/*' />
    SpvOpUConvert = 113,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSConvert"]/*' />
    SpvOpSConvert = 114,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFConvert"]/*' />
    SpvOpFConvert = 115,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpQuantizeToF16"]/*' />
    SpvOpQuantizeToF16 = 116,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertPtrToU"]/*' />
    SpvOpConvertPtrToU = 117,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSatConvertSToU"]/*' />
    SpvOpSatConvertSToU = 118,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSatConvertUToS"]/*' />
    SpvOpSatConvertUToS = 119,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertUToPtr"]/*' />
    SpvOpConvertUToPtr = 120,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPtrCastToGeneric"]/*' />
    SpvOpPtrCastToGeneric = 121,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGenericCastToPtr"]/*' />
    SpvOpGenericCastToPtr = 122,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGenericCastToPtrExplicit"]/*' />
    SpvOpGenericCastToPtrExplicit = 123,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitcast"]/*' />
    SpvOpBitcast = 124,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSNegate"]/*' />
    SpvOpSNegate = 126,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFNegate"]/*' />
    SpvOpFNegate = 127,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIAdd"]/*' />
    SpvOpIAdd = 128,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFAdd"]/*' />
    SpvOpFAdd = 129,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpISub"]/*' />
    SpvOpISub = 130,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFSub"]/*' />
    SpvOpFSub = 131,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIMul"]/*' />
    SpvOpIMul = 132,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFMul"]/*' />
    SpvOpFMul = 133,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUDiv"]/*' />
    SpvOpUDiv = 134,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSDiv"]/*' />
    SpvOpSDiv = 135,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFDiv"]/*' />
    SpvOpFDiv = 136,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUMod"]/*' />
    SpvOpUMod = 137,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSRem"]/*' />
    SpvOpSRem = 138,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSMod"]/*' />
    SpvOpSMod = 139,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFRem"]/*' />
    SpvOpFRem = 140,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFMod"]/*' />
    SpvOpFMod = 141,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVectorTimesScalar"]/*' />
    SpvOpVectorTimesScalar = 142,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMatrixTimesScalar"]/*' />
    SpvOpMatrixTimesScalar = 143,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVectorTimesMatrix"]/*' />
    SpvOpVectorTimesMatrix = 144,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMatrixTimesVector"]/*' />
    SpvOpMatrixTimesVector = 145,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMatrixTimesMatrix"]/*' />
    SpvOpMatrixTimesMatrix = 146,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpOuterProduct"]/*' />
    SpvOpOuterProduct = 147,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDot"]/*' />
    SpvOpDot = 148,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIAddCarry"]/*' />
    SpvOpIAddCarry = 149,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpISubBorrow"]/*' />
    SpvOpISubBorrow = 150,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUMulExtended"]/*' />
    SpvOpUMulExtended = 151,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSMulExtended"]/*' />
    SpvOpSMulExtended = 152,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAny"]/*' />
    SpvOpAny = 154,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAll"]/*' />
    SpvOpAll = 155,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsNan"]/*' />
    SpvOpIsNan = 156,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsInf"]/*' />
    SpvOpIsInf = 157,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsFinite"]/*' />
    SpvOpIsFinite = 158,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsNormal"]/*' />
    SpvOpIsNormal = 159,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSignBitSet"]/*' />
    SpvOpSignBitSet = 160,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLessOrGreater"]/*' />
    SpvOpLessOrGreater = 161,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpOrdered"]/*' />
    SpvOpOrdered = 162,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUnordered"]/*' />
    SpvOpUnordered = 163,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLogicalEqual"]/*' />
    SpvOpLogicalEqual = 164,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLogicalNotEqual"]/*' />
    SpvOpLogicalNotEqual = 165,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLogicalOr"]/*' />
    SpvOpLogicalOr = 166,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLogicalAnd"]/*' />
    SpvOpLogicalAnd = 167,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLogicalNot"]/*' />
    SpvOpLogicalNot = 168,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSelect"]/*' />
    SpvOpSelect = 169,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIEqual"]/*' />
    SpvOpIEqual = 170,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpINotEqual"]/*' />
    SpvOpINotEqual = 171,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUGreaterThan"]/*' />
    SpvOpUGreaterThan = 172,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSGreaterThan"]/*' />
    SpvOpSGreaterThan = 173,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUGreaterThanEqual"]/*' />
    SpvOpUGreaterThanEqual = 174,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSGreaterThanEqual"]/*' />
    SpvOpSGreaterThanEqual = 175,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpULessThan"]/*' />
    SpvOpULessThan = 176,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSLessThan"]/*' />
    SpvOpSLessThan = 177,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpULessThanEqual"]/*' />
    SpvOpULessThanEqual = 178,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSLessThanEqual"]/*' />
    SpvOpSLessThanEqual = 179,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFOrdEqual"]/*' />
    SpvOpFOrdEqual = 180,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFUnordEqual"]/*' />
    SpvOpFUnordEqual = 181,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFOrdNotEqual"]/*' />
    SpvOpFOrdNotEqual = 182,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFUnordNotEqual"]/*' />
    SpvOpFUnordNotEqual = 183,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFOrdLessThan"]/*' />
    SpvOpFOrdLessThan = 184,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFUnordLessThan"]/*' />
    SpvOpFUnordLessThan = 185,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFOrdGreaterThan"]/*' />
    SpvOpFOrdGreaterThan = 186,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFUnordGreaterThan"]/*' />
    SpvOpFUnordGreaterThan = 187,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFOrdLessThanEqual"]/*' />
    SpvOpFOrdLessThanEqual = 188,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFUnordLessThanEqual"]/*' />
    SpvOpFUnordLessThanEqual = 189,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFOrdGreaterThanEqual"]/*' />
    SpvOpFOrdGreaterThanEqual = 190,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFUnordGreaterThanEqual"]/*' />
    SpvOpFUnordGreaterThanEqual = 191,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpShiftRightLogical"]/*' />
    SpvOpShiftRightLogical = 194,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpShiftRightArithmetic"]/*' />
    SpvOpShiftRightArithmetic = 195,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpShiftLeftLogical"]/*' />
    SpvOpShiftLeftLogical = 196,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitwiseOr"]/*' />
    SpvOpBitwiseOr = 197,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitwiseXor"]/*' />
    SpvOpBitwiseXor = 198,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitwiseAnd"]/*' />
    SpvOpBitwiseAnd = 199,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpNot"]/*' />
    SpvOpNot = 200,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitFieldInsert"]/*' />
    SpvOpBitFieldInsert = 201,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitFieldSExtract"]/*' />
    SpvOpBitFieldSExtract = 202,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitFieldUExtract"]/*' />
    SpvOpBitFieldUExtract = 203,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitReverse"]/*' />
    SpvOpBitReverse = 204,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBitCount"]/*' />
    SpvOpBitCount = 205,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDPdx"]/*' />
    SpvOpDPdx = 207,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDPdy"]/*' />
    SpvOpDPdy = 208,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFwidth"]/*' />
    SpvOpFwidth = 209,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDPdxFine"]/*' />
    SpvOpDPdxFine = 210,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDPdyFine"]/*' />
    SpvOpDPdyFine = 211,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFwidthFine"]/*' />
    SpvOpFwidthFine = 212,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDPdxCoarse"]/*' />
    SpvOpDPdxCoarse = 213,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDPdyCoarse"]/*' />
    SpvOpDPdyCoarse = 214,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFwidthCoarse"]/*' />
    SpvOpFwidthCoarse = 215,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEmitVertex"]/*' />
    SpvOpEmitVertex = 218,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEndPrimitive"]/*' />
    SpvOpEndPrimitive = 219,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEmitStreamVertex"]/*' />
    SpvOpEmitStreamVertex = 220,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEndStreamPrimitive"]/*' />
    SpvOpEndStreamPrimitive = 221,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpControlBarrier"]/*' />
    SpvOpControlBarrier = 224,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemoryBarrier"]/*' />
    SpvOpMemoryBarrier = 225,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicLoad"]/*' />
    SpvOpAtomicLoad = 227,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicStore"]/*' />
    SpvOpAtomicStore = 228,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicExchange"]/*' />
    SpvOpAtomicExchange = 229,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicCompareExchange"]/*' />
    SpvOpAtomicCompareExchange = 230,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicCompareExchangeWeak"]/*' />
    SpvOpAtomicCompareExchangeWeak = 231,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicIIncrement"]/*' />
    SpvOpAtomicIIncrement = 232,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicIDecrement"]/*' />
    SpvOpAtomicIDecrement = 233,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicIAdd"]/*' />
    SpvOpAtomicIAdd = 234,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicISub"]/*' />
    SpvOpAtomicISub = 235,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicSMin"]/*' />
    SpvOpAtomicSMin = 236,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicUMin"]/*' />
    SpvOpAtomicUMin = 237,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicSMax"]/*' />
    SpvOpAtomicSMax = 238,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicUMax"]/*' />
    SpvOpAtomicUMax = 239,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicAnd"]/*' />
    SpvOpAtomicAnd = 240,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicOr"]/*' />
    SpvOpAtomicOr = 241,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicXor"]/*' />
    SpvOpAtomicXor = 242,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPhi"]/*' />
    SpvOpPhi = 245,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLoopMerge"]/*' />
    SpvOpLoopMerge = 246,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSelectionMerge"]/*' />
    SpvOpSelectionMerge = 247,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLabel"]/*' />
    SpvOpLabel = 248,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBranch"]/*' />
    SpvOpBranch = 249,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBranchConditional"]/*' />
    SpvOpBranchConditional = 250,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSwitch"]/*' />
    SpvOpSwitch = 251,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpKill"]/*' />
    SpvOpKill = 252,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReturn"]/*' />
    SpvOpReturn = 253,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReturnValue"]/*' />
    SpvOpReturnValue = 254,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUnreachable"]/*' />
    SpvOpUnreachable = 255,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLifetimeStart"]/*' />
    SpvOpLifetimeStart = 256,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLifetimeStop"]/*' />
    SpvOpLifetimeStop = 257,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupAsyncCopy"]/*' />
    SpvOpGroupAsyncCopy = 259,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupWaitEvents"]/*' />
    SpvOpGroupWaitEvents = 260,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupAll"]/*' />
    SpvOpGroupAll = 261,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupAny"]/*' />
    SpvOpGroupAny = 262,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupBroadcast"]/*' />
    SpvOpGroupBroadcast = 263,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupIAdd"]/*' />
    SpvOpGroupIAdd = 264,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFAdd"]/*' />
    SpvOpGroupFAdd = 265,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFMin"]/*' />
    SpvOpGroupFMin = 266,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupUMin"]/*' />
    SpvOpGroupUMin = 267,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupSMin"]/*' />
    SpvOpGroupSMin = 268,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFMax"]/*' />
    SpvOpGroupFMax = 269,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupUMax"]/*' />
    SpvOpGroupUMax = 270,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupSMax"]/*' />
    SpvOpGroupSMax = 271,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReadPipe"]/*' />
    SpvOpReadPipe = 274,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpWritePipe"]/*' />
    SpvOpWritePipe = 275,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReservedReadPipe"]/*' />
    SpvOpReservedReadPipe = 276,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReservedWritePipe"]/*' />
    SpvOpReservedWritePipe = 277,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReserveReadPipePackets"]/*' />
    SpvOpReserveReadPipePackets = 278,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReserveWritePipePackets"]/*' />
    SpvOpReserveWritePipePackets = 279,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCommitReadPipe"]/*' />
    SpvOpCommitReadPipe = 280,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCommitWritePipe"]/*' />
    SpvOpCommitWritePipe = 281,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsValidReserveId"]/*' />
    SpvOpIsValidReserveId = 282,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetNumPipePackets"]/*' />
    SpvOpGetNumPipePackets = 283,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetMaxPipePackets"]/*' />
    SpvOpGetMaxPipePackets = 284,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupReserveReadPipePackets"]/*' />
    SpvOpGroupReserveReadPipePackets = 285,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupReserveWritePipePackets"]/*' />
    SpvOpGroupReserveWritePipePackets = 286,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupCommitReadPipe"]/*' />
    SpvOpGroupCommitReadPipe = 287,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupCommitWritePipe"]/*' />
    SpvOpGroupCommitWritePipe = 288,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEnqueueMarker"]/*' />
    SpvOpEnqueueMarker = 291,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEnqueueKernel"]/*' />
    SpvOpEnqueueKernel = 292,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetKernelNDrangeSubGroupCount"]/*' />
    SpvOpGetKernelNDrangeSubGroupCount = 293,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetKernelNDrangeMaxSubGroupSize"]/*' />
    SpvOpGetKernelNDrangeMaxSubGroupSize = 294,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetKernelWorkGroupSize"]/*' />
    SpvOpGetKernelWorkGroupSize = 295,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetKernelPreferredWorkGroupSizeMultiple"]/*' />
    SpvOpGetKernelPreferredWorkGroupSizeMultiple = 296,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRetainEvent"]/*' />
    SpvOpRetainEvent = 297,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReleaseEvent"]/*' />
    SpvOpReleaseEvent = 298,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCreateUserEvent"]/*' />
    SpvOpCreateUserEvent = 299,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsValidEvent"]/*' />
    SpvOpIsValidEvent = 300,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSetUserEventStatus"]/*' />
    SpvOpSetUserEventStatus = 301,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCaptureEventProfilingInfo"]/*' />
    SpvOpCaptureEventProfilingInfo = 302,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetDefaultQueue"]/*' />
    SpvOpGetDefaultQueue = 303,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBuildNDRange"]/*' />
    SpvOpBuildNDRange = 304,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleImplicitLod"]/*' />
    SpvOpImageSparseSampleImplicitLod = 305,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleExplicitLod"]/*' />
    SpvOpImageSparseSampleExplicitLod = 306,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleDrefImplicitLod"]/*' />
    SpvOpImageSparseSampleDrefImplicitLod = 307,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleDrefExplicitLod"]/*' />
    SpvOpImageSparseSampleDrefExplicitLod = 308,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleProjImplicitLod"]/*' />
    SpvOpImageSparseSampleProjImplicitLod = 309,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleProjExplicitLod"]/*' />
    SpvOpImageSparseSampleProjExplicitLod = 310,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleProjDrefImplicitLod"]/*' />
    SpvOpImageSparseSampleProjDrefImplicitLod = 311,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseSampleProjDrefExplicitLod"]/*' />
    SpvOpImageSparseSampleProjDrefExplicitLod = 312,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseFetch"]/*' />
    SpvOpImageSparseFetch = 313,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseGather"]/*' />
    SpvOpImageSparseGather = 314,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseDrefGather"]/*' />
    SpvOpImageSparseDrefGather = 315,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseTexelsResident"]/*' />
    SpvOpImageSparseTexelsResident = 316,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpNoLine"]/*' />
    SpvOpNoLine = 317,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicFlagTestAndSet"]/*' />
    SpvOpAtomicFlagTestAndSet = 318,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicFlagClear"]/*' />
    SpvOpAtomicFlagClear = 319,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSparseRead"]/*' />
    SpvOpImageSparseRead = 320,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSizeOf"]/*' />
    SpvOpSizeOf = 321,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypePipeStorage"]/*' />
    SpvOpTypePipeStorage = 322,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantPipeStorage"]/*' />
    SpvOpConstantPipeStorage = 323,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCreatePipeFromPipeStorage"]/*' />
    SpvOpCreatePipeFromPipeStorage = 324,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetKernelLocalSizeForSubgroupCount"]/*' />
    SpvOpGetKernelLocalSizeForSubgroupCount = 325,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGetKernelMaxNumSubgroups"]/*' />
    SpvOpGetKernelMaxNumSubgroups = 326,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeNamedBarrier"]/*' />
    SpvOpTypeNamedBarrier = 327,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpNamedBarrierInitialize"]/*' />
    SpvOpNamedBarrierInitialize = 328,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemoryNamedBarrier"]/*' />
    SpvOpMemoryNamedBarrier = 329,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpModuleProcessed"]/*' />
    SpvOpModuleProcessed = 330,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExecutionModeId"]/*' />
    SpvOpExecutionModeId = 331,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDecorateId"]/*' />
    SpvOpDecorateId = 332,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformElect"]/*' />
    SpvOpGroupNonUniformElect = 333,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformAll"]/*' />
    SpvOpGroupNonUniformAll = 334,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformAny"]/*' />
    SpvOpGroupNonUniformAny = 335,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformAllEqual"]/*' />
    SpvOpGroupNonUniformAllEqual = 336,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBroadcast"]/*' />
    SpvOpGroupNonUniformBroadcast = 337,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBroadcastFirst"]/*' />
    SpvOpGroupNonUniformBroadcastFirst = 338,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBallot"]/*' />
    SpvOpGroupNonUniformBallot = 339,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformInverseBallot"]/*' />
    SpvOpGroupNonUniformInverseBallot = 340,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBallotBitExtract"]/*' />
    SpvOpGroupNonUniformBallotBitExtract = 341,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBallotBitCount"]/*' />
    SpvOpGroupNonUniformBallotBitCount = 342,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBallotFindLSB"]/*' />
    SpvOpGroupNonUniformBallotFindLSB = 343,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBallotFindMSB"]/*' />
    SpvOpGroupNonUniformBallotFindMSB = 344,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformShuffle"]/*' />
    SpvOpGroupNonUniformShuffle = 345,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformShuffleXor"]/*' />
    SpvOpGroupNonUniformShuffleXor = 346,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformShuffleUp"]/*' />
    SpvOpGroupNonUniformShuffleUp = 347,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformShuffleDown"]/*' />
    SpvOpGroupNonUniformShuffleDown = 348,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformIAdd"]/*' />
    SpvOpGroupNonUniformIAdd = 349,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformFAdd"]/*' />
    SpvOpGroupNonUniformFAdd = 350,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformIMul"]/*' />
    SpvOpGroupNonUniformIMul = 351,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformFMul"]/*' />
    SpvOpGroupNonUniformFMul = 352,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformSMin"]/*' />
    SpvOpGroupNonUniformSMin = 353,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformUMin"]/*' />
    SpvOpGroupNonUniformUMin = 354,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformFMin"]/*' />
    SpvOpGroupNonUniformFMin = 355,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformSMax"]/*' />
    SpvOpGroupNonUniformSMax = 356,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformUMax"]/*' />
    SpvOpGroupNonUniformUMax = 357,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformFMax"]/*' />
    SpvOpGroupNonUniformFMax = 358,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBitwiseAnd"]/*' />
    SpvOpGroupNonUniformBitwiseAnd = 359,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBitwiseOr"]/*' />
    SpvOpGroupNonUniformBitwiseOr = 360,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformBitwiseXor"]/*' />
    SpvOpGroupNonUniformBitwiseXor = 361,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformLogicalAnd"]/*' />
    SpvOpGroupNonUniformLogicalAnd = 362,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformLogicalOr"]/*' />
    SpvOpGroupNonUniformLogicalOr = 363,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformLogicalXor"]/*' />
    SpvOpGroupNonUniformLogicalXor = 364,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformQuadBroadcast"]/*' />
    SpvOpGroupNonUniformQuadBroadcast = 365,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformQuadSwap"]/*' />
    SpvOpGroupNonUniformQuadSwap = 366,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCopyLogical"]/*' />
    SpvOpCopyLogical = 400,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPtrEqual"]/*' />
    SpvOpPtrEqual = 401,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPtrNotEqual"]/*' />
    SpvOpPtrNotEqual = 402,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPtrDiff"]/*' />
    SpvOpPtrDiff = 403,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTerminateInvocation"]/*' />
    SpvOpTerminateInvocation = 4416,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupBallotKHR"]/*' />
    SpvOpSubgroupBallotKHR = 4421,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupFirstInvocationKHR"]/*' />
    SpvOpSubgroupFirstInvocationKHR = 4422,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAllKHR"]/*' />
    SpvOpSubgroupAllKHR = 4428,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAnyKHR"]/*' />
    SpvOpSubgroupAnyKHR = 4429,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAllEqualKHR"]/*' />
    SpvOpSubgroupAllEqualKHR = 4430,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformRotateKHR"]/*' />
    SpvOpGroupNonUniformRotateKHR = 4431,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupReadInvocationKHR"]/*' />
    SpvOpSubgroupReadInvocationKHR = 4432,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTraceRayKHR"]/*' />
    SpvOpTraceRayKHR = 4445,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExecuteCallableKHR"]/*' />
    SpvOpExecuteCallableKHR = 4446,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertUToAccelerationStructureKHR"]/*' />
    SpvOpConvertUToAccelerationStructureKHR = 4447,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIgnoreIntersectionKHR"]/*' />
    SpvOpIgnoreIntersectionKHR = 4448,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTerminateRayKHR"]/*' />
    SpvOpTerminateRayKHR = 4449,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSDot"]/*' />
    SpvOpSDot = 4450,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSDotKHR"]/*' />
    SpvOpSDotKHR = 4450,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUDot"]/*' />
    SpvOpUDot = 4451,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUDotKHR"]/*' />
    SpvOpUDotKHR = 4451,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSUDot"]/*' />
    SpvOpSUDot = 4452,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSUDotKHR"]/*' />
    SpvOpSUDotKHR = 4452,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSDotAccSat"]/*' />
    SpvOpSDotAccSat = 4453,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSDotAccSatKHR"]/*' />
    SpvOpSDotAccSatKHR = 4453,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUDotAccSat"]/*' />
    SpvOpUDotAccSat = 4454,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUDotAccSatKHR"]/*' />
    SpvOpUDotAccSatKHR = 4454,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSUDotAccSat"]/*' />
    SpvOpSUDotAccSat = 4455,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSUDotAccSatKHR"]/*' />
    SpvOpSUDotAccSatKHR = 4455,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeRayQueryKHR"]/*' />
    SpvOpTypeRayQueryKHR = 4472,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryInitializeKHR"]/*' />
    SpvOpRayQueryInitializeKHR = 4473,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryTerminateKHR"]/*' />
    SpvOpRayQueryTerminateKHR = 4474,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGenerateIntersectionKHR"]/*' />
    SpvOpRayQueryGenerateIntersectionKHR = 4475,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryConfirmIntersectionKHR"]/*' />
    SpvOpRayQueryConfirmIntersectionKHR = 4476,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryProceedKHR"]/*' />
    SpvOpRayQueryProceedKHR = 4477,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionTypeKHR"]/*' />
    SpvOpRayQueryGetIntersectionTypeKHR = 4479,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupIAddNonUniformAMD"]/*' />
    SpvOpGroupIAddNonUniformAMD = 5000,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFAddNonUniformAMD"]/*' />
    SpvOpGroupFAddNonUniformAMD = 5001,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFMinNonUniformAMD"]/*' />
    SpvOpGroupFMinNonUniformAMD = 5002,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupUMinNonUniformAMD"]/*' />
    SpvOpGroupUMinNonUniformAMD = 5003,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupSMinNonUniformAMD"]/*' />
    SpvOpGroupSMinNonUniformAMD = 5004,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFMaxNonUniformAMD"]/*' />
    SpvOpGroupFMaxNonUniformAMD = 5005,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupUMaxNonUniformAMD"]/*' />
    SpvOpGroupUMaxNonUniformAMD = 5006,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupSMaxNonUniformAMD"]/*' />
    SpvOpGroupSMaxNonUniformAMD = 5007,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFragmentMaskFetchAMD"]/*' />
    SpvOpFragmentMaskFetchAMD = 5011,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFragmentFetchAMD"]/*' />
    SpvOpFragmentFetchAMD = 5012,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReadClockKHR"]/*' />
    SpvOpReadClockKHR = 5056,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpImageSampleFootprintNV"]/*' />
    SpvOpImageSampleFootprintNV = 5283,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEmitMeshTasksEXT"]/*' />
    SpvOpEmitMeshTasksEXT = 5294,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSetMeshOutputsEXT"]/*' />
    SpvOpSetMeshOutputsEXT = 5295,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupNonUniformPartitionNV"]/*' />
    SpvOpGroupNonUniformPartitionNV = 5296,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpWritePackedPrimitiveIndices4x8NV"]/*' />
    SpvOpWritePackedPrimitiveIndices4x8NV = 5299,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReportIntersectionKHR"]/*' />
    SpvOpReportIntersectionKHR = 5334,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReportIntersectionNV"]/*' />
    SpvOpReportIntersectionNV = 5334,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIgnoreIntersectionNV"]/*' />
    SpvOpIgnoreIntersectionNV = 5335,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTerminateRayNV"]/*' />
    SpvOpTerminateRayNV = 5336,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTraceNV"]/*' />
    SpvOpTraceNV = 5337,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTraceMotionNV"]/*' />
    SpvOpTraceMotionNV = 5338,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTraceRayMotionNV"]/*' />
    SpvOpTraceRayMotionNV = 5339,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAccelerationStructureKHR"]/*' />
    SpvOpTypeAccelerationStructureKHR = 5341,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAccelerationStructureNV"]/*' />
    SpvOpTypeAccelerationStructureNV = 5341,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExecuteCallableNV"]/*' />
    SpvOpExecuteCallableNV = 5344,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeCooperativeMatrixNV"]/*' />
    SpvOpTypeCooperativeMatrixNV = 5358,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCooperativeMatrixLoadNV"]/*' />
    SpvOpCooperativeMatrixLoadNV = 5359,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCooperativeMatrixStoreNV"]/*' />
    SpvOpCooperativeMatrixStoreNV = 5360,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCooperativeMatrixMulAddNV"]/*' />
    SpvOpCooperativeMatrixMulAddNV = 5361,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCooperativeMatrixLengthNV"]/*' />
    SpvOpCooperativeMatrixLengthNV = 5362,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpBeginInvocationInterlockEXT"]/*' />
    SpvOpBeginInvocationInterlockEXT = 5364,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpEndInvocationInterlockEXT"]/*' />
    SpvOpEndInvocationInterlockEXT = 5365,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDemoteToHelperInvocation"]/*' />
    SpvOpDemoteToHelperInvocation = 5380,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDemoteToHelperInvocationEXT"]/*' />
    SpvOpDemoteToHelperInvocationEXT = 5380,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIsHelperInvocationEXT"]/*' />
    SpvOpIsHelperInvocationEXT = 5381,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertUToImageNV"]/*' />
    SpvOpConvertUToImageNV = 5391,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertUToSamplerNV"]/*' />
    SpvOpConvertUToSamplerNV = 5392,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertImageToUNV"]/*' />
    SpvOpConvertImageToUNV = 5393,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertSamplerToUNV"]/*' />
    SpvOpConvertSamplerToUNV = 5394,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertUToSampledImageNV"]/*' />
    SpvOpConvertUToSampledImageNV = 5395,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConvertSampledImageToUNV"]/*' />
    SpvOpConvertSampledImageToUNV = 5396,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSamplerImageAddressingModeNV"]/*' />
    SpvOpSamplerImageAddressingModeNV = 5397,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupShuffleINTEL"]/*' />
    SpvOpSubgroupShuffleINTEL = 5571,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupShuffleDownINTEL"]/*' />
    SpvOpSubgroupShuffleDownINTEL = 5572,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupShuffleUpINTEL"]/*' />
    SpvOpSubgroupShuffleUpINTEL = 5573,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupShuffleXorINTEL"]/*' />
    SpvOpSubgroupShuffleXorINTEL = 5574,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupBlockReadINTEL"]/*' />
    SpvOpSubgroupBlockReadINTEL = 5575,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupBlockWriteINTEL"]/*' />
    SpvOpSubgroupBlockWriteINTEL = 5576,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupImageBlockReadINTEL"]/*' />
    SpvOpSubgroupImageBlockReadINTEL = 5577,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupImageBlockWriteINTEL"]/*' />
    SpvOpSubgroupImageBlockWriteINTEL = 5578,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupImageMediaBlockReadINTEL"]/*' />
    SpvOpSubgroupImageMediaBlockReadINTEL = 5580,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupImageMediaBlockWriteINTEL"]/*' />
    SpvOpSubgroupImageMediaBlockWriteINTEL = 5581,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUCountLeadingZerosINTEL"]/*' />
    SpvOpUCountLeadingZerosINTEL = 5585,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUCountTrailingZerosINTEL"]/*' />
    SpvOpUCountTrailingZerosINTEL = 5586,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAbsISubINTEL"]/*' />
    SpvOpAbsISubINTEL = 5587,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAbsUSubINTEL"]/*' />
    SpvOpAbsUSubINTEL = 5588,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIAddSatINTEL"]/*' />
    SpvOpIAddSatINTEL = 5589,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUAddSatINTEL"]/*' />
    SpvOpUAddSatINTEL = 5590,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIAverageINTEL"]/*' />
    SpvOpIAverageINTEL = 5591,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUAverageINTEL"]/*' />
    SpvOpUAverageINTEL = 5592,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIAverageRoundedINTEL"]/*' />
    SpvOpIAverageRoundedINTEL = 5593,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUAverageRoundedINTEL"]/*' />
    SpvOpUAverageRoundedINTEL = 5594,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpISubSatINTEL"]/*' />
    SpvOpISubSatINTEL = 5595,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUSubSatINTEL"]/*' />
    SpvOpUSubSatINTEL = 5596,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpIMul32x16INTEL"]/*' />
    SpvOpIMul32x16INTEL = 5597,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpUMul32x16INTEL"]/*' />
    SpvOpUMul32x16INTEL = 5598,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantFunctionPointerINTEL"]/*' />
    SpvOpConstantFunctionPointerINTEL = 5600,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFunctionPointerCallINTEL"]/*' />
    SpvOpFunctionPointerCallINTEL = 5601,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAsmTargetINTEL"]/*' />
    SpvOpAsmTargetINTEL = 5609,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAsmINTEL"]/*' />
    SpvOpAsmINTEL = 5610,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAsmCallINTEL"]/*' />
    SpvOpAsmCallINTEL = 5611,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicFMinEXT"]/*' />
    SpvOpAtomicFMinEXT = 5614,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicFMaxEXT"]/*' />
    SpvOpAtomicFMaxEXT = 5615,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAssumeTrueKHR"]/*' />
    SpvOpAssumeTrueKHR = 5630,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpExpectKHR"]/*' />
    SpvOpExpectKHR = 5631,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDecorateString"]/*' />
    SpvOpDecorateString = 5632,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpDecorateStringGOOGLE"]/*' />
    SpvOpDecorateStringGOOGLE = 5632,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemberDecorateString"]/*' />
    SpvOpMemberDecorateString = 5633,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMemberDecorateStringGOOGLE"]/*' />
    SpvOpMemberDecorateStringGOOGLE = 5633,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVmeImageINTEL"]/*' />
    SpvOpVmeImageINTEL = 5699,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeVmeImageINTEL"]/*' />
    SpvOpTypeVmeImageINTEL = 5700,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcImePayloadINTEL"]/*' />
    SpvOpTypeAvcImePayloadINTEL = 5701,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcRefPayloadINTEL"]/*' />
    SpvOpTypeAvcRefPayloadINTEL = 5702,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcSicPayloadINTEL"]/*' />
    SpvOpTypeAvcSicPayloadINTEL = 5703,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcMcePayloadINTEL"]/*' />
    SpvOpTypeAvcMcePayloadINTEL = 5704,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcMceResultINTEL"]/*' />
    SpvOpTypeAvcMceResultINTEL = 5705,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcImeResultINTEL"]/*' />
    SpvOpTypeAvcImeResultINTEL = 5706,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcImeResultSingleReferenceStreamoutINTEL"]/*' />
    SpvOpTypeAvcImeResultSingleReferenceStreamoutINTEL = 5707,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcImeResultDualReferenceStreamoutINTEL"]/*' />
    SpvOpTypeAvcImeResultDualReferenceStreamoutINTEL = 5708,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcImeSingleReferenceStreaminINTEL"]/*' />
    SpvOpTypeAvcImeSingleReferenceStreaminINTEL = 5709,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcImeDualReferenceStreaminINTEL"]/*' />
    SpvOpTypeAvcImeDualReferenceStreaminINTEL = 5710,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcRefResultINTEL"]/*' />
    SpvOpTypeAvcRefResultINTEL = 5711,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeAvcSicResultINTEL"]/*' />
    SpvOpTypeAvcSicResultINTEL = 5712,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL = 5713,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL = 5714,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL = 5715,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetInterShapePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceSetInterShapePenaltyINTEL = 5716,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL = 5717,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetInterDirectionPenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceSetInterDirectionPenaltyINTEL = 5718,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL = 5719,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL = 5720,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL = 5721,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL = 5722,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL = 5723,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL"]/*' />
    SpvOpSubgroupAvcMceSetMotionVectorCostFunctionINTEL = 5724,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL = 5725,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL = 5726,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL = 5727,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetAcOnlyHaarINTEL"]/*' />
    SpvOpSubgroupAvcMceSetAcOnlyHaarINTEL = 5728,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL"]/*' />
    SpvOpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL = 5729,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL"]/*' />
    SpvOpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL = 5730,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL"]/*' />
    SpvOpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL = 5731,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceConvertToImePayloadINTEL"]/*' />
    SpvOpSubgroupAvcMceConvertToImePayloadINTEL = 5732,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceConvertToImeResultINTEL"]/*' />
    SpvOpSubgroupAvcMceConvertToImeResultINTEL = 5733,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceConvertToRefPayloadINTEL"]/*' />
    SpvOpSubgroupAvcMceConvertToRefPayloadINTEL = 5734,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceConvertToRefResultINTEL"]/*' />
    SpvOpSubgroupAvcMceConvertToRefResultINTEL = 5735,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceConvertToSicPayloadINTEL"]/*' />
    SpvOpSubgroupAvcMceConvertToSicPayloadINTEL = 5736,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceConvertToSicResultINTEL"]/*' />
    SpvOpSubgroupAvcMceConvertToSicResultINTEL = 5737,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetMotionVectorsINTEL"]/*' />
    SpvOpSubgroupAvcMceGetMotionVectorsINTEL = 5738,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterDistortionsINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterDistortionsINTEL = 5739,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetBestInterDistortionsINTEL"]/*' />
    SpvOpSubgroupAvcMceGetBestInterDistortionsINTEL = 5740,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterMajorShapeINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterMajorShapeINTEL = 5741,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterMinorShapeINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterMinorShapeINTEL = 5742,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterDirectionsINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterDirectionsINTEL = 5743,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterMotionVectorCountINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterMotionVectorCountINTEL = 5744,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterReferenceIdsINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterReferenceIdsINTEL = 5745,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL"]/*' />
    SpvOpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL = 5746,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeInitializeINTEL"]/*' />
    SpvOpSubgroupAvcImeInitializeINTEL = 5747,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeSetSingleReferenceINTEL"]/*' />
    SpvOpSubgroupAvcImeSetSingleReferenceINTEL = 5748,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeSetDualReferenceINTEL"]/*' />
    SpvOpSubgroupAvcImeSetDualReferenceINTEL = 5749,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeRefWindowSizeINTEL"]/*' />
    SpvOpSubgroupAvcImeRefWindowSizeINTEL = 5750,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeAdjustRefOffsetINTEL"]/*' />
    SpvOpSubgroupAvcImeAdjustRefOffsetINTEL = 5751,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeConvertToMcePayloadINTEL"]/*' />
    SpvOpSubgroupAvcImeConvertToMcePayloadINTEL = 5752,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeSetMaxMotionVectorCountINTEL"]/*' />
    SpvOpSubgroupAvcImeSetMaxMotionVectorCountINTEL = 5753,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL"]/*' />
    SpvOpSubgroupAvcImeSetUnidirectionalMixDisableINTEL = 5754,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL"]/*' />
    SpvOpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL = 5755,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeSetWeightedSadINTEL"]/*' />
    SpvOpSubgroupAvcImeSetWeightedSadINTEL = 5756,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithSingleReferenceINTEL = 5757,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithDualReferenceINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithDualReferenceINTEL = 5758,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL = 5759,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL = 5760,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL = 5761,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL = 5762,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL = 5763,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL"]/*' />
    SpvOpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL = 5764,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeConvertToMceResultINTEL"]/*' />
    SpvOpSubgroupAvcImeConvertToMceResultINTEL = 5765,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetSingleReferenceStreaminINTEL"]/*' />
    SpvOpSubgroupAvcImeGetSingleReferenceStreaminINTEL = 5766,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetDualReferenceStreaminINTEL"]/*' />
    SpvOpSubgroupAvcImeGetDualReferenceStreaminINTEL = 5767,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL"]/*' />
    SpvOpSubgroupAvcImeStripSingleReferenceStreamoutINTEL = 5768,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeStripDualReferenceStreamoutINTEL"]/*' />
    SpvOpSubgroupAvcImeStripDualReferenceStreamoutINTEL = 5769,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL"]/*' />
    SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL = 5770,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL"]/*' />
    SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL = 5771,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL"]/*' />
    SpvOpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL = 5772,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL"]/*' />
    SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL = 5773,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL"]/*' />
    SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL = 5774,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL"]/*' />
    SpvOpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL = 5775,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetBorderReachedINTEL"]/*' />
    SpvOpSubgroupAvcImeGetBorderReachedINTEL = 5776,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL"]/*' />
    SpvOpSubgroupAvcImeGetTruncatedSearchIndicationINTEL = 5777,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL"]/*' />
    SpvOpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL = 5778,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL"]/*' />
    SpvOpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL = 5779,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL"]/*' />
    SpvOpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL = 5780,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcFmeInitializeINTEL"]/*' />
    SpvOpSubgroupAvcFmeInitializeINTEL = 5781,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcBmeInitializeINTEL"]/*' />
    SpvOpSubgroupAvcBmeInitializeINTEL = 5782,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefConvertToMcePayloadINTEL"]/*' />
    SpvOpSubgroupAvcRefConvertToMcePayloadINTEL = 5783,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefSetBidirectionalMixDisableINTEL"]/*' />
    SpvOpSubgroupAvcRefSetBidirectionalMixDisableINTEL = 5784,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefSetBilinearFilterEnableINTEL"]/*' />
    SpvOpSubgroupAvcRefSetBilinearFilterEnableINTEL = 5785,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL"]/*' />
    SpvOpSubgroupAvcRefEvaluateWithSingleReferenceINTEL = 5786,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefEvaluateWithDualReferenceINTEL"]/*' />
    SpvOpSubgroupAvcRefEvaluateWithDualReferenceINTEL = 5787,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL"]/*' />
    SpvOpSubgroupAvcRefEvaluateWithMultiReferenceINTEL = 5788,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL"]/*' />
    SpvOpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL = 5789,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcRefConvertToMceResultINTEL"]/*' />
    SpvOpSubgroupAvcRefConvertToMceResultINTEL = 5790,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicInitializeINTEL"]/*' />
    SpvOpSubgroupAvcSicInitializeINTEL = 5791,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicConfigureSkcINTEL"]/*' />
    SpvOpSubgroupAvcSicConfigureSkcINTEL = 5792,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicConfigureIpeLumaINTEL"]/*' />
    SpvOpSubgroupAvcSicConfigureIpeLumaINTEL = 5793,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicConfigureIpeLumaChromaINTEL"]/*' />
    SpvOpSubgroupAvcSicConfigureIpeLumaChromaINTEL = 5794,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetMotionVectorMaskINTEL"]/*' />
    SpvOpSubgroupAvcSicGetMotionVectorMaskINTEL = 5795,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicConvertToMcePayloadINTEL"]/*' />
    SpvOpSubgroupAvcSicConvertToMcePayloadINTEL = 5796,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL"]/*' />
    SpvOpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL = 5797,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL"]/*' />
    SpvOpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL = 5798,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL"]/*' />
    SpvOpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL = 5799,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicSetBilinearFilterEnableINTEL"]/*' />
    SpvOpSubgroupAvcSicSetBilinearFilterEnableINTEL = 5800,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL"]/*' />
    SpvOpSubgroupAvcSicSetSkcForwardTransformEnableINTEL = 5801,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL"]/*' />
    SpvOpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL = 5802,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicEvaluateIpeINTEL"]/*' />
    SpvOpSubgroupAvcSicEvaluateIpeINTEL = 5803,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL"]/*' />
    SpvOpSubgroupAvcSicEvaluateWithSingleReferenceINTEL = 5804,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicEvaluateWithDualReferenceINTEL"]/*' />
    SpvOpSubgroupAvcSicEvaluateWithDualReferenceINTEL = 5805,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL"]/*' />
    SpvOpSubgroupAvcSicEvaluateWithMultiReferenceINTEL = 5806,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL"]/*' />
    SpvOpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL = 5807,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicConvertToMceResultINTEL"]/*' />
    SpvOpSubgroupAvcSicConvertToMceResultINTEL = 5808,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetIpeLumaShapeINTEL"]/*' />
    SpvOpSubgroupAvcSicGetIpeLumaShapeINTEL = 5809,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL"]/*' />
    SpvOpSubgroupAvcSicGetBestIpeLumaDistortionINTEL = 5810,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL"]/*' />
    SpvOpSubgroupAvcSicGetBestIpeChromaDistortionINTEL = 5811,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetPackedIpeLumaModesINTEL"]/*' />
    SpvOpSubgroupAvcSicGetPackedIpeLumaModesINTEL = 5812,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetIpeChromaModeINTEL"]/*' />
    SpvOpSubgroupAvcSicGetIpeChromaModeINTEL = 5813,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL"]/*' />
    SpvOpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL = 5814,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL"]/*' />
    SpvOpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL = 5815,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSubgroupAvcSicGetInterRawSadsINTEL"]/*' />
    SpvOpSubgroupAvcSicGetInterRawSadsINTEL = 5816,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpVariableLengthArrayINTEL"]/*' />
    SpvOpVariableLengthArrayINTEL = 5818,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSaveMemoryINTEL"]/*' />
    SpvOpSaveMemoryINTEL = 5819,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRestoreMemoryINTEL"]/*' />
    SpvOpRestoreMemoryINTEL = 5820,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatSinCosPiINTEL"]/*' />
    SpvOpArbitraryFloatSinCosPiINTEL = 5840,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatCastINTEL"]/*' />
    SpvOpArbitraryFloatCastINTEL = 5841,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatCastFromIntINTEL"]/*' />
    SpvOpArbitraryFloatCastFromIntINTEL = 5842,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatCastToIntINTEL"]/*' />
    SpvOpArbitraryFloatCastToIntINTEL = 5843,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatAddINTEL"]/*' />
    SpvOpArbitraryFloatAddINTEL = 5846,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatSubINTEL"]/*' />
    SpvOpArbitraryFloatSubINTEL = 5847,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatMulINTEL"]/*' />
    SpvOpArbitraryFloatMulINTEL = 5848,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatDivINTEL"]/*' />
    SpvOpArbitraryFloatDivINTEL = 5849,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatGTINTEL"]/*' />
    SpvOpArbitraryFloatGTINTEL = 5850,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatGEINTEL"]/*' />
    SpvOpArbitraryFloatGEINTEL = 5851,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatLTINTEL"]/*' />
    SpvOpArbitraryFloatLTINTEL = 5852,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatLEINTEL"]/*' />
    SpvOpArbitraryFloatLEINTEL = 5853,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatEQINTEL"]/*' />
    SpvOpArbitraryFloatEQINTEL = 5854,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatRecipINTEL"]/*' />
    SpvOpArbitraryFloatRecipINTEL = 5855,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatRSqrtINTEL"]/*' />
    SpvOpArbitraryFloatRSqrtINTEL = 5856,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatCbrtINTEL"]/*' />
    SpvOpArbitraryFloatCbrtINTEL = 5857,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatHypotINTEL"]/*' />
    SpvOpArbitraryFloatHypotINTEL = 5858,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatSqrtINTEL"]/*' />
    SpvOpArbitraryFloatSqrtINTEL = 5859,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatLogINTEL"]/*' />
    SpvOpArbitraryFloatLogINTEL = 5860,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatLog2INTEL"]/*' />
    SpvOpArbitraryFloatLog2INTEL = 5861,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatLog10INTEL"]/*' />
    SpvOpArbitraryFloatLog10INTEL = 5862,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatLog1pINTEL"]/*' />
    SpvOpArbitraryFloatLog1pINTEL = 5863,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatExpINTEL"]/*' />
    SpvOpArbitraryFloatExpINTEL = 5864,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatExp2INTEL"]/*' />
    SpvOpArbitraryFloatExp2INTEL = 5865,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatExp10INTEL"]/*' />
    SpvOpArbitraryFloatExp10INTEL = 5866,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatExpm1INTEL"]/*' />
    SpvOpArbitraryFloatExpm1INTEL = 5867,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatSinINTEL"]/*' />
    SpvOpArbitraryFloatSinINTEL = 5868,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatCosINTEL"]/*' />
    SpvOpArbitraryFloatCosINTEL = 5869,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatSinCosINTEL"]/*' />
    SpvOpArbitraryFloatSinCosINTEL = 5870,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatSinPiINTEL"]/*' />
    SpvOpArbitraryFloatSinPiINTEL = 5871,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatCosPiINTEL"]/*' />
    SpvOpArbitraryFloatCosPiINTEL = 5872,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatASinINTEL"]/*' />
    SpvOpArbitraryFloatASinINTEL = 5873,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatASinPiINTEL"]/*' />
    SpvOpArbitraryFloatASinPiINTEL = 5874,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatACosINTEL"]/*' />
    SpvOpArbitraryFloatACosINTEL = 5875,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatACosPiINTEL"]/*' />
    SpvOpArbitraryFloatACosPiINTEL = 5876,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatATanINTEL"]/*' />
    SpvOpArbitraryFloatATanINTEL = 5877,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatATanPiINTEL"]/*' />
    SpvOpArbitraryFloatATanPiINTEL = 5878,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatATan2INTEL"]/*' />
    SpvOpArbitraryFloatATan2INTEL = 5879,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatPowINTEL"]/*' />
    SpvOpArbitraryFloatPowINTEL = 5880,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatPowRINTEL"]/*' />
    SpvOpArbitraryFloatPowRINTEL = 5881,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpArbitraryFloatPowNINTEL"]/*' />
    SpvOpArbitraryFloatPowNINTEL = 5882,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpLoopControlINTEL"]/*' />
    SpvOpLoopControlINTEL = 5887,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAliasDomainDeclINTEL"]/*' />
    SpvOpAliasDomainDeclINTEL = 5911,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAliasScopeDeclINTEL"]/*' />
    SpvOpAliasScopeDeclINTEL = 5912,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAliasScopeListDeclINTEL"]/*' />
    SpvOpAliasScopeListDeclINTEL = 5913,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedSqrtINTEL"]/*' />
    SpvOpFixedSqrtINTEL = 5923,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedRecipINTEL"]/*' />
    SpvOpFixedRecipINTEL = 5924,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedRsqrtINTEL"]/*' />
    SpvOpFixedRsqrtINTEL = 5925,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedSinINTEL"]/*' />
    SpvOpFixedSinINTEL = 5926,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedCosINTEL"]/*' />
    SpvOpFixedCosINTEL = 5927,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedSinCosINTEL"]/*' />
    SpvOpFixedSinCosINTEL = 5928,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedSinPiINTEL"]/*' />
    SpvOpFixedSinPiINTEL = 5929,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedCosPiINTEL"]/*' />
    SpvOpFixedCosPiINTEL = 5930,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedSinCosPiINTEL"]/*' />
    SpvOpFixedSinCosPiINTEL = 5931,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedLogINTEL"]/*' />
    SpvOpFixedLogINTEL = 5932,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFixedExpINTEL"]/*' />
    SpvOpFixedExpINTEL = 5933,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpPtrCastToCrossWorkgroupINTEL"]/*' />
    SpvOpPtrCastToCrossWorkgroupINTEL = 5934,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpCrossWorkgroupCastToPtrINTEL"]/*' />
    SpvOpCrossWorkgroupCastToPtrINTEL = 5938,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpReadPipeBlockingINTEL"]/*' />
    SpvOpReadPipeBlockingINTEL = 5946,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpWritePipeBlockingINTEL"]/*' />
    SpvOpWritePipeBlockingINTEL = 5947,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpFPGARegINTEL"]/*' />
    SpvOpFPGARegINTEL = 5949,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetRayTMinKHR"]/*' />
    SpvOpRayQueryGetRayTMinKHR = 6016,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetRayFlagsKHR"]/*' />
    SpvOpRayQueryGetRayFlagsKHR = 6017,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionTKHR"]/*' />
    SpvOpRayQueryGetIntersectionTKHR = 6018,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionInstanceCustomIndexKHR"]/*' />
    SpvOpRayQueryGetIntersectionInstanceCustomIndexKHR = 6019,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionInstanceIdKHR"]/*' />
    SpvOpRayQueryGetIntersectionInstanceIdKHR = 6020,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR"]/*' />
    SpvOpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR = 6021,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionGeometryIndexKHR"]/*' />
    SpvOpRayQueryGetIntersectionGeometryIndexKHR = 6022,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionPrimitiveIndexKHR"]/*' />
    SpvOpRayQueryGetIntersectionPrimitiveIndexKHR = 6023,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionBarycentricsKHR"]/*' />
    SpvOpRayQueryGetIntersectionBarycentricsKHR = 6024,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionFrontFaceKHR"]/*' />
    SpvOpRayQueryGetIntersectionFrontFaceKHR = 6025,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionCandidateAABBOpaqueKHR"]/*' />
    SpvOpRayQueryGetIntersectionCandidateAABBOpaqueKHR = 6026,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionObjectRayDirectionKHR"]/*' />
    SpvOpRayQueryGetIntersectionObjectRayDirectionKHR = 6027,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionObjectRayOriginKHR"]/*' />
    SpvOpRayQueryGetIntersectionObjectRayOriginKHR = 6028,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetWorldRayDirectionKHR"]/*' />
    SpvOpRayQueryGetWorldRayDirectionKHR = 6029,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetWorldRayOriginKHR"]/*' />
    SpvOpRayQueryGetWorldRayOriginKHR = 6030,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionObjectToWorldKHR"]/*' />
    SpvOpRayQueryGetIntersectionObjectToWorldKHR = 6031,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpRayQueryGetIntersectionWorldToObjectKHR"]/*' />
    SpvOpRayQueryGetIntersectionWorldToObjectKHR = 6032,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpAtomicFAddEXT"]/*' />
    SpvOpAtomicFAddEXT = 6035,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeBufferSurfaceINTEL"]/*' />
    SpvOpTypeBufferSurfaceINTEL = 6086,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpTypeStructContinuedINTEL"]/*' />
    SpvOpTypeStructContinuedINTEL = 6090,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpConstantCompositeContinuedINTEL"]/*' />
    SpvOpConstantCompositeContinuedINTEL = 6091,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpSpecConstantCompositeContinuedINTEL"]/*' />
    SpvOpSpecConstantCompositeContinuedINTEL = 6092,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpControlBarrierArriveINTEL"]/*' />
    SpvOpControlBarrierArriveINTEL = 6142,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpControlBarrierWaitINTEL"]/*' />
    SpvOpControlBarrierWaitINTEL = 6143,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupIMulKHR"]/*' />
    SpvOpGroupIMulKHR = 6401,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupFMulKHR"]/*' />
    SpvOpGroupFMulKHR = 6402,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupBitwiseAndKHR"]/*' />
    SpvOpGroupBitwiseAndKHR = 6403,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupBitwiseOrKHR"]/*' />
    SpvOpGroupBitwiseOrKHR = 6404,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupBitwiseXorKHR"]/*' />
    SpvOpGroupBitwiseXorKHR = 6405,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupLogicalAndKHR"]/*' />
    SpvOpGroupLogicalAndKHR = 6406,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupLogicalOrKHR"]/*' />
    SpvOpGroupLogicalOrKHR = 6407,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpGroupLogicalXorKHR"]/*' />
    SpvOpGroupLogicalXorKHR = 6408,

    /// <include file='SpvOp.xml' path='doc/member[@name="SpvOp.SpvOpMax"]/*' />
    SpvOpMax = 0x7fffffff,
}
