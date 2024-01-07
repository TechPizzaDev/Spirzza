namespace Spirzza.Interop.Shaderc;

/// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status"]/*' />
public enum shaderc_compilation_status
{
    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_success"]/*' />
    shaderc_compilation_status_success = 0,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_invalid_stage"]/*' />
    shaderc_compilation_status_invalid_stage = 1,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_compilation_error"]/*' />
    shaderc_compilation_status_compilation_error = 2,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_internal_error"]/*' />
    shaderc_compilation_status_internal_error = 3,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_null_result_object"]/*' />
    shaderc_compilation_status_null_result_object = 4,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_invalid_assembly"]/*' />
    shaderc_compilation_status_invalid_assembly = 5,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_validation_error"]/*' />
    shaderc_compilation_status_validation_error = 6,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_transformation_error"]/*' />
    shaderc_compilation_status_transformation_error = 7,

    /// <include file='shaderc_compilation_status.xml' path='doc/member[@name="shaderc_compilation_status.shaderc_compilation_status_configuration_error"]/*' />
    shaderc_compilation_status_configuration_error = 8,
}
