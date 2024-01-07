namespace Spirzza.Interop.Shaderc;

/// <include file='shaderc_target_env.xml' path='doc/member[@name="shaderc_target_env"]/*' />
public enum shaderc_target_env
{
    /// <include file='shaderc_target_env.xml' path='doc/member[@name="shaderc_target_env.shaderc_target_env_vulkan"]/*' />
    shaderc_target_env_vulkan,

    /// <include file='shaderc_target_env.xml' path='doc/member[@name="shaderc_target_env.shaderc_target_env_opengl"]/*' />
    shaderc_target_env_opengl,

    /// <include file='shaderc_target_env.xml' path='doc/member[@name="shaderc_target_env.shaderc_target_env_opengl_compat"]/*' />
    shaderc_target_env_opengl_compat,

    /// <include file='shaderc_target_env.xml' path='doc/member[@name="shaderc_target_env.shaderc_target_env_webgpu"]/*' />
    shaderc_target_env_webgpu,

    /// <include file='shaderc_target_env.xml' path='doc/member[@name="shaderc_target_env.shaderc_target_env_default"]/*' />
    shaderc_target_env_default = shaderc_target_env_vulkan,
}
