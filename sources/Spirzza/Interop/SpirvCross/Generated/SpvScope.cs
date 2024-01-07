namespace Spirzza.Interop.SpirvCross;

/// <include file='SpvScope.xml' path='doc/member[@name="SpvScope"]/*' />
public enum SpvScope
{
    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeCrossDevice"]/*' />
    SpvScopeCrossDevice = 0,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeDevice"]/*' />
    SpvScopeDevice = 1,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeWorkgroup"]/*' />
    SpvScopeWorkgroup = 2,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeSubgroup"]/*' />
    SpvScopeSubgroup = 3,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeInvocation"]/*' />
    SpvScopeInvocation = 4,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeQueueFamily"]/*' />
    SpvScopeQueueFamily = 5,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeQueueFamilyKHR"]/*' />
    SpvScopeQueueFamilyKHR = 5,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeShaderCallKHR"]/*' />
    SpvScopeShaderCallKHR = 6,

    /// <include file='SpvScope.xml' path='doc/member[@name="SpvScope.SpvScopeMax"]/*' />
    SpvScopeMax = 0x7fffffff,
}
