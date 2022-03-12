
namespace Spirzza.Interop.SpirvCross
{
    public static unsafe partial class SpirvCross
    {
		public static int SPVC_MAKE_MSL_VERSION(int major, int minor, int patch) 
		{
			return major * 10000 + minor * 100 + patch;
		}
    }
}