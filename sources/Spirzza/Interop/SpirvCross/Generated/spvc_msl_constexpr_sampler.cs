namespace Spirzza.Interop.SpirvCross;

/// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler"]/*' />
public partial struct spvc_msl_constexpr_sampler
{
    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.coord"]/*' />
    public spvc_msl_sampler_coord coord;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.min_filter"]/*' />
    public spvc_msl_sampler_filter min_filter;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.mag_filter"]/*' />
    public spvc_msl_sampler_filter mag_filter;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.mip_filter"]/*' />
    public spvc_msl_sampler_mip_filter mip_filter;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.s_address"]/*' />
    public spvc_msl_sampler_address s_address;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.t_address"]/*' />
    public spvc_msl_sampler_address t_address;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.r_address"]/*' />
    public spvc_msl_sampler_address r_address;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.compare_func"]/*' />
    public spvc_msl_sampler_compare_func compare_func;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.border_color"]/*' />
    public spvc_msl_sampler_border_color border_color;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.lod_clamp_min"]/*' />
    public float lod_clamp_min;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.lod_clamp_max"]/*' />
    public float lod_clamp_max;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.max_anisotropy"]/*' />
    public int max_anisotropy;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.compare_enable"]/*' />
    public spvc_bool compare_enable;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.lod_clamp_enable"]/*' />
    public spvc_bool lod_clamp_enable;

    /// <include file='spvc_msl_constexpr_sampler.xml' path='doc/member[@name="spvc_msl_constexpr_sampler.anisotropy_enable"]/*' />
    public spvc_bool anisotropy_enable;
}
