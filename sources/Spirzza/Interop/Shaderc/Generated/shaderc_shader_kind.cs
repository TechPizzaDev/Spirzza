namespace Spirzza.Interop.Shaderc;

/// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind"]/*' />
public enum shaderc_shader_kind
{
    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_vertex_shader"]/*' />
    shaderc_vertex_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_fragment_shader"]/*' />
    shaderc_fragment_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_compute_shader"]/*' />
    shaderc_compute_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_geometry_shader"]/*' />
    shaderc_geometry_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_tess_control_shader"]/*' />
    shaderc_tess_control_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_tess_evaluation_shader"]/*' />
    shaderc_tess_evaluation_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_vertex_shader"]/*' />
    shaderc_glsl_vertex_shader = shaderc_vertex_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_fragment_shader"]/*' />
    shaderc_glsl_fragment_shader = shaderc_fragment_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_compute_shader"]/*' />
    shaderc_glsl_compute_shader = shaderc_compute_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_geometry_shader"]/*' />
    shaderc_glsl_geometry_shader = shaderc_geometry_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_tess_control_shader"]/*' />
    shaderc_glsl_tess_control_shader = shaderc_tess_control_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_tess_evaluation_shader"]/*' />
    shaderc_glsl_tess_evaluation_shader = shaderc_tess_evaluation_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_infer_from_source"]/*' />
    shaderc_glsl_infer_from_source,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_vertex_shader"]/*' />
    shaderc_glsl_default_vertex_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_fragment_shader"]/*' />
    shaderc_glsl_default_fragment_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_compute_shader"]/*' />
    shaderc_glsl_default_compute_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_geometry_shader"]/*' />
    shaderc_glsl_default_geometry_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_tess_control_shader"]/*' />
    shaderc_glsl_default_tess_control_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_tess_evaluation_shader"]/*' />
    shaderc_glsl_default_tess_evaluation_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_spirv_assembly"]/*' />
    shaderc_spirv_assembly,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_raygen_shader"]/*' />
    shaderc_raygen_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_anyhit_shader"]/*' />
    shaderc_anyhit_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_closesthit_shader"]/*' />
    shaderc_closesthit_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_miss_shader"]/*' />
    shaderc_miss_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_intersection_shader"]/*' />
    shaderc_intersection_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_callable_shader"]/*' />
    shaderc_callable_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_raygen_shader"]/*' />
    shaderc_glsl_raygen_shader = shaderc_raygen_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_anyhit_shader"]/*' />
    shaderc_glsl_anyhit_shader = shaderc_anyhit_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_closesthit_shader"]/*' />
    shaderc_glsl_closesthit_shader = shaderc_closesthit_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_miss_shader"]/*' />
    shaderc_glsl_miss_shader = shaderc_miss_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_intersection_shader"]/*' />
    shaderc_glsl_intersection_shader = shaderc_intersection_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_callable_shader"]/*' />
    shaderc_glsl_callable_shader = shaderc_callable_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_raygen_shader"]/*' />
    shaderc_glsl_default_raygen_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_anyhit_shader"]/*' />
    shaderc_glsl_default_anyhit_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_closesthit_shader"]/*' />
    shaderc_glsl_default_closesthit_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_miss_shader"]/*' />
    shaderc_glsl_default_miss_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_intersection_shader"]/*' />
    shaderc_glsl_default_intersection_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_callable_shader"]/*' />
    shaderc_glsl_default_callable_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_task_shader"]/*' />
    shaderc_task_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_mesh_shader"]/*' />
    shaderc_mesh_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_task_shader"]/*' />
    shaderc_glsl_task_shader = shaderc_task_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_mesh_shader"]/*' />
    shaderc_glsl_mesh_shader = shaderc_mesh_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_task_shader"]/*' />
    shaderc_glsl_default_task_shader,

    /// <include file='shaderc_shader_kind.xml' path='doc/member[@name="shaderc_shader_kind.shaderc_glsl_default_mesh_shader"]/*' />
    shaderc_glsl_default_mesh_shader,
}
