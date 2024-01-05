using System.Runtime.InteropServices;

namespace Spirzza.Interop.SpirvCross
{
    public static unsafe partial class SpirvCross
    {
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_get_version([NativeTypeName("unsigned int *")] uint* major, [NativeTypeName("unsigned int *")] uint* minor, [NativeTypeName("unsigned int *")] uint* patch);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_get_commit_revision_and_timestamp();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_msl_vertex_attribute_init(spvc_msl_vertex_attribute* attr);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_msl_shader_input_init(spvc_msl_shader_input* input);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_msl_resource_binding_init(spvc_msl_resource_binding* binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_msl_get_aux_buffer_struct_version();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_msl_constexpr_sampler_init(spvc_msl_constexpr_sampler* sampler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_msl_sampler_ycbcr_conversion_init(spvc_msl_sampler_ycbcr_conversion* conv);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_hlsl_resource_binding_init(spvc_hlsl_resource_binding* binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_context_create([NativeTypeName("spvc_context *")] spvc_context** context);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_context_destroy([NativeTypeName("spvc_context")] spvc_context* context);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_context_release_allocations([NativeTypeName("spvc_context")] spvc_context* context);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_context_get_last_error_string([NativeTypeName("spvc_context")] spvc_context* context);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_context_set_error_callback([NativeTypeName("spvc_context")] spvc_context* context, [NativeTypeName("spvc_error_callback")] delegate* unmanaged[Cdecl]<void*, sbyte*, void> cb, void* userdata);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_context_parse_spirv([NativeTypeName("spvc_context")] spvc_context* context, [NativeTypeName("const SpvId *")] SpvId* spirv, [NativeTypeName("size_t")] nuint word_count, [NativeTypeName("spvc_parsed_ir *")] spvc_parsed_ir** parsed_ir);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_context_create_compiler([NativeTypeName("spvc_context")] spvc_context* context, spvc_backend backend, [NativeTypeName("spvc_parsed_ir")] spvc_parsed_ir* parsed_ir, spvc_capture_mode mode, [NativeTypeName("spvc_compiler *")] spvc_compiler** compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_get_current_id_bound([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_create_compiler_options([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_compiler_options *")] spvc_compiler_options** options);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_options_set_bool([NativeTypeName("spvc_compiler_options")] spvc_compiler_options* options, spvc_compiler_option option, spvc_bool value);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_options_set_uint([NativeTypeName("spvc_compiler_options")] spvc_compiler_options* options, spvc_compiler_option option, [NativeTypeName("unsigned int")] uint value);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_install_compiler_options([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_compiler_options")] spvc_compiler_options* options);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_compile([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char **")] sbyte** source);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_add_header_line([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char *")] sbyte* line);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_require_extension([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char *")] sbyte* ext);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_flatten_buffer_block([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_variable_is_depth_or_compare([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_mask_stage_output_by_location([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint location, [NativeTypeName("unsigned int")] uint component);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_mask_stage_output_by_builtin([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvBuiltIn builtin);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_hlsl_set_root_constants_layout([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_hlsl_root_constants *")] spvc_hlsl_root_constants* constant_info, [NativeTypeName("size_t")] nuint count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_hlsl_add_vertex_attribute_remap([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_hlsl_vertex_attribute_remap *")] spvc_hlsl_vertex_attribute_remap* remap, [NativeTypeName("size_t")] nuint remaps);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_variable_id spvc_compiler_hlsl_remap_num_workgroups_builtin([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_hlsl_set_resource_binding_flags([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_hlsl_binding_flags")] spvc_hlsl_binding_flag_bits flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_hlsl_add_resource_binding([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_hlsl_resource_binding *")] spvc_hlsl_resource_binding* binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_hlsl_is_resource_used([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionModel model, [NativeTypeName("unsigned int")] uint set, [NativeTypeName("unsigned int")] uint binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_is_rasterization_disabled([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_needs_aux_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_needs_swizzle_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_needs_buffer_size_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_needs_output_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_needs_patch_output_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_needs_input_threadgroup_mem([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_add_vertex_attribute([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_msl_vertex_attribute *")] spvc_msl_vertex_attribute* attrs);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_add_resource_binding([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_msl_resource_binding *")] spvc_msl_resource_binding* binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_add_shader_input([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_msl_shader_input *")] spvc_msl_shader_input* input);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_add_discrete_descriptor_set([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint desc_set);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_set_argument_buffer_device_address_space([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint desc_set, spvc_bool device_address);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_is_vertex_attribute_used([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint location);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_is_shader_input_used([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint location);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_msl_is_resource_used([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionModel model, [NativeTypeName("unsigned int")] uint set, [NativeTypeName("unsigned int")] uint binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id, [NativeTypeName("const spvc_msl_constexpr_sampler *")] spvc_msl_constexpr_sampler* sampler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler_by_binding([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint desc_set, [NativeTypeName("unsigned int")] uint binding, [NativeTypeName("const spvc_msl_constexpr_sampler *")] spvc_msl_constexpr_sampler* sampler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler_ycbcr([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id, [NativeTypeName("const spvc_msl_constexpr_sampler *")] spvc_msl_constexpr_sampler* sampler, [NativeTypeName("const spvc_msl_sampler_ycbcr_conversion *")] spvc_msl_sampler_ycbcr_conversion* conv);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint desc_set, [NativeTypeName("unsigned int")] uint binding, [NativeTypeName("const spvc_msl_constexpr_sampler *")] spvc_msl_constexpr_sampler* sampler, [NativeTypeName("const spvc_msl_sampler_ycbcr_conversion *")] spvc_msl_sampler_ycbcr_conversion* conv);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_set_fragment_output_components([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint location, [NativeTypeName("unsigned int")] uint components);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_msl_get_automatic_resource_binding([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_msl_get_automatic_resource_binding_secondary([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_add_dynamic_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint desc_set, [NativeTypeName("unsigned int")] uint binding, [NativeTypeName("unsigned int")] uint index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_add_inline_uniform_block([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("unsigned int")] uint desc_set, [NativeTypeName("unsigned int")] uint binding);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_msl_set_combined_sampler_suffix([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char *")] sbyte* suffix);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_msl_get_combined_sampler_suffix([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_active_interface_variables([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_set *")] spvc_set** set);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_set_enabled_interface_variables([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_set")] spvc_set* set);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_create_shader_resources([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_resources *")] spvc_resources** resources);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_create_shader_resources_for_active_variables([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_resources *")] spvc_resources** resources, [NativeTypeName("spvc_set")] spvc_set* active);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_resources_get_resource_list_for_type([NativeTypeName("spvc_resources")] spvc_resources* resources, spvc_resource_type type, [NativeTypeName("const spvc_reflected_resource **")] spvc_reflected_resource** resource_list, [NativeTypeName("size_t *")] nuint* resource_size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_resources_get_builtin_resource_list_for_type([NativeTypeName("spvc_resources")] spvc_resources* resources, spvc_builtin_resource_type type, [NativeTypeName("const spvc_reflected_builtin_resource **")] spvc_reflected_builtin_resource** resource_list, [NativeTypeName("size_t *")] nuint* resource_size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, SpvDecoration decoration, [NativeTypeName("unsigned int")] uint argument);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_decoration_string([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, SpvDecoration decoration, [NativeTypeName("const char *")] sbyte* argument);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_name([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, [NativeTypeName("const char *")] sbyte* argument);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_member_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, SpvDecoration decoration, [NativeTypeName("unsigned int")] uint argument);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_member_decoration_string([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, SpvDecoration decoration, [NativeTypeName("const char *")] sbyte* argument);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_member_name([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, [NativeTypeName("const char *")] sbyte* argument);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_unset_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_unset_member_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_has_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_has_member_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_get_name([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_get_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_get_decoration_string([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvId id, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_get_member_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_get_member_decoration_string([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index, SpvDecoration decoration);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_get_member_name([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id, [NativeTypeName("unsigned int")] uint member_index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_entry_points([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_entry_point **")] spvc_entry_point** entry_points, [NativeTypeName("size_t *")] nuint* num_entry_points);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_set_entry_point([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char *")] sbyte* name, SpvExecutionModel model);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_rename_entry_point([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char *")] sbyte* old_name, [NativeTypeName("const char *")] sbyte* new_name, SpvExecutionModel model);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_get_cleansed_entry_point_name([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char *")] sbyte* name, SpvExecutionModel model);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_execution_mode([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionMode mode);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_unset_execution_mode([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionMode mode);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_set_execution_mode_with_arguments([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionMode mode, [NativeTypeName("unsigned int")] uint arg0, [NativeTypeName("unsigned int")] uint arg1, [NativeTypeName("unsigned int")] uint arg2);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_execution_modes([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const SpvExecutionMode **")] SpvExecutionMode** modes, [NativeTypeName("size_t *")] nuint* num_modes);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_get_execution_mode_argument([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionMode mode);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_compiler_get_execution_mode_argument_by_index([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvExecutionMode mode, [NativeTypeName("unsigned int")] uint index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SpvExecutionModel spvc_compiler_get_execution_model([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_compiler_update_active_builtins([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_has_active_builtin([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, SpvBuiltIn builtin, SpvStorageClass storage);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("spvc_type")]
        public static extern spvc_type* spvc_compiler_get_type_handle([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_type_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_type_id spvc_type_get_base_type_id([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_basetype spvc_type_get_basetype([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_type_get_bit_width([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_type_get_vector_size([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_type_get_columns([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_type_get_num_array_dimensions([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_type_array_dimension_is_literal([NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint dimension);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SpvId spvc_type_get_array_dimension([NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint dimension);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_type_get_num_member_types([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_type_id spvc_type_get_member_type([NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SpvStorageClass spvc_type_get_storage_class([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_type_id spvc_type_get_image_sampled_type([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SpvDim spvc_type_get_image_dimension([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_type_get_image_is_depth([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_type_get_image_arrayed([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_type_get_image_multisampled([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_type_get_image_is_storage([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SpvImageFormat spvc_type_get_image_storage_format([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SpvAccessQualifier spvc_type_get_image_access_qualifier([NativeTypeName("spvc_type")] spvc_type* type);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_declared_struct_size([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_type")] spvc_type* struct_type, [NativeTypeName("size_t *")] nuint* size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_declared_struct_size_runtime_array([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_type")] spvc_type* struct_type, [NativeTypeName("size_t")] nuint array_size, [NativeTypeName("size_t *")] nuint* size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_declared_struct_member_size([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("size_t *")] nuint* size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_type_struct_member_offset([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("unsigned int *")] uint* offset);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_type_struct_member_array_stride([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("unsigned int *")] uint* stride);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_type_struct_member_matrix_stride([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("spvc_type")] spvc_type* type, [NativeTypeName("unsigned int")] uint index, [NativeTypeName("unsigned int *")] uint* stride);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_build_dummy_sampler_for_combined_images([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id* id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_build_combined_image_samplers([NativeTypeName("spvc_compiler")] spvc_compiler* compiler);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_combined_image_samplers([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_combined_image_sampler **")] spvc_combined_image_sampler** samplers, [NativeTypeName("size_t *")] nuint* num_samplers);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_specialization_constants([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const spvc_specialization_constant **")] spvc_specialization_constant** constants, [NativeTypeName("size_t *")] nuint* num_constants);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("spvc_constant")]
        public static extern spvc_constant* spvc_compiler_get_constant_handle([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_constant_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_constant_id spvc_compiler_get_work_group_size_specialization_constants([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_specialization_constant* x, spvc_specialization_constant* y, spvc_specialization_constant* z);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_active_buffer_ranges([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id, [NativeTypeName("const spvc_buffer_range **")] spvc_buffer_range** ranges, [NativeTypeName("size_t *")] nuint* num_ranges);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float spvc_constant_get_scalar_fp16([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float spvc_constant_get_scalar_fp32([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double spvc_constant_get_scalar_fp64([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_constant_get_scalar_u32([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int spvc_constant_get_scalar_i32([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_constant_get_scalar_u16([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int spvc_constant_get_scalar_i16([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint spvc_constant_get_scalar_u8([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int spvc_constant_get_scalar_i8([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("unsigned int")] uint column, [NativeTypeName("unsigned int")] uint row);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void spvc_constant_get_subconstants([NativeTypeName("spvc_constant")] spvc_constant* constant, [NativeTypeName("const spvc_constant_id **")] spvc_constant_id** constituents, [NativeTypeName("size_t *")] nuint* count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_type_id spvc_constant_get_type([NativeTypeName("spvc_constant")] spvc_constant* constant);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_get_binary_offset_for_decoration([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id, SpvDecoration decoration, [NativeTypeName("unsigned int *")] uint* word_offset);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_buffer_is_hlsl_counter_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_bool spvc_compiler_buffer_get_hlsl_counter_buffer([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id, spvc_variable_id* counter_id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_declared_capabilities([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const SpvCapability **")] SpvCapability** capabilities, [NativeTypeName("size_t *")] nuint* num_capabilities);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_declared_extensions([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, [NativeTypeName("const char ***")] sbyte*** extensions, [NativeTypeName("size_t *")] nuint* num_extensions);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* spvc_compiler_get_remapped_declared_block_name([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern spvc_result spvc_compiler_get_buffer_block_decorations([NativeTypeName("spvc_compiler")] spvc_compiler* compiler, spvc_variable_id id, [NativeTypeName("const SpvDecoration **")] SpvDecoration** decorations, [NativeTypeName("size_t *")] nuint* num_decorations);

        [NativeTypeName("#define SPVC_C_API_VERSION_MAJOR 0")]
        public const int SPVC_C_API_VERSION_MAJOR = 0;

        [NativeTypeName("#define SPVC_C_API_VERSION_MINOR 49")]
        public const int SPVC_C_API_VERSION_MINOR = 49;

        [NativeTypeName("#define SPVC_C_API_VERSION_PATCH 0")]
        public const int SPVC_C_API_VERSION_PATCH = 0;

        [NativeTypeName("#define SPVC_TRUE ((spvc_bool)1)")]
        public const byte SPVC_TRUE = unchecked((byte)(1));

        [NativeTypeName("#define SPVC_FALSE ((spvc_bool)0)")]
        public const byte SPVC_FALSE = unchecked((byte)(0));

        [NativeTypeName("#define SPVC_COMPILER_OPTION_COMMON_BIT 0x1000000")]
        public const int SPVC_COMPILER_OPTION_COMMON_BIT = 0x1000000;

        [NativeTypeName("#define SPVC_COMPILER_OPTION_GLSL_BIT 0x2000000")]
        public const int SPVC_COMPILER_OPTION_GLSL_BIT = 0x2000000;

        [NativeTypeName("#define SPVC_COMPILER_OPTION_HLSL_BIT 0x4000000")]
        public const int SPVC_COMPILER_OPTION_HLSL_BIT = 0x4000000;

        [NativeTypeName("#define SPVC_COMPILER_OPTION_MSL_BIT 0x8000000")]
        public const int SPVC_COMPILER_OPTION_MSL_BIT = 0x8000000;

        [NativeTypeName("#define SPVC_COMPILER_OPTION_LANG_BITS 0x0f000000")]
        public const int SPVC_COMPILER_OPTION_LANG_BITS = 0x0f000000;

        [NativeTypeName("#define SPVC_COMPILER_OPTION_ENUM_BITS 0xffffff")]
        public const int SPVC_COMPILER_OPTION_ENUM_BITS = 0xffffff;

        [NativeTypeName("#define SPVC_MSL_PUSH_CONSTANT_DESC_SET (~(0u))")]
        public const uint SPVC_MSL_PUSH_CONSTANT_DESC_SET = (~(0U));

        [NativeTypeName("#define SPVC_MSL_PUSH_CONSTANT_BINDING (0)")]
        public const int SPVC_MSL_PUSH_CONSTANT_BINDING = (0);

        [NativeTypeName("#define SPVC_MSL_SWIZZLE_BUFFER_BINDING (~(1u))")]
        public const uint SPVC_MSL_SWIZZLE_BUFFER_BINDING = (~(1U));

        [NativeTypeName("#define SPVC_MSL_BUFFER_SIZE_BUFFER_BINDING (~(2u))")]
        public const uint SPVC_MSL_BUFFER_SIZE_BUFFER_BINDING = (~(2U));

        [NativeTypeName("#define SPVC_MSL_ARGUMENT_BUFFER_BINDING (~(3u))")]
        public const uint SPVC_MSL_ARGUMENT_BUFFER_BINDING = (~(3U));

        [NativeTypeName("#define SPVC_MSL_AUX_BUFFER_STRUCT_VERSION 1")]
        public const int SPVC_MSL_AUX_BUFFER_STRUCT_VERSION = 1;

        [NativeTypeName("#define SPVC_HLSL_PUSH_CONSTANT_DESC_SET (~(0u))")]
        public const uint SPVC_HLSL_PUSH_CONSTANT_DESC_SET = (~(0U));

        [NativeTypeName("#define SPVC_HLSL_PUSH_CONSTANT_BINDING (0)")]
        public const int SPVC_HLSL_PUSH_CONSTANT_BINDING = (0);

        [NativeTypeName("const unsigned int")]
        public const uint SpvMagicNumber = 0x07230203;

        [NativeTypeName("const unsigned int")]
        public const uint SpvVersion = 0x00010600;

        [NativeTypeName("const unsigned int")]
        public const uint SpvRevision = 1;

        [NativeTypeName("const unsigned int")]
        public const uint SpvOpCodeMask = 0xffff;

        [NativeTypeName("const unsigned int")]
        public const uint SpvWordCountShift = 16;

        [NativeTypeName("#define SPV_VERSION 0x10600")]
        public const int SPV_VERSION = 0x10600;

        [NativeTypeName("#define SPV_REVISION 1")]
        public const int SPV_REVISION = 1;
    }
}
