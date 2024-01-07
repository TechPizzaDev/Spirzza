namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel"]/*' />
public enum SpvMemoryModel
{
    /// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel.SpvMemoryModelSimple"]/*' />
    SpvMemoryModelSimple = 0,

    /// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel.SpvMemoryModelGLSL450"]/*' />
    SpvMemoryModelGLSL450 = 1,

    /// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel.SpvMemoryModelOpenCL"]/*' />
    SpvMemoryModelOpenCL = 2,

    /// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel.SpvMemoryModelVulkan"]/*' />
    SpvMemoryModelVulkan = 3,

    /// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel.SpvMemoryModelVulkanKHR"]/*' />
    SpvMemoryModelVulkanKHR = 3,

    /// <include file='SpvMemoryModel.xml' path='doc/member[@name="SpvMemoryModel.SpvMemoryModelMax"]/*' />
    SpvMemoryModelMax = 0x7fffffff,
}
