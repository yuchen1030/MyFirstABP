using Abp.Application.Services;

namespace FirstABP
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class FirstABPAppServiceBase : ApplicationService
    {
        protected FirstABPAppServiceBase()
        {
            LocalizationSourceName = FirstABPConsts.LocalizationSourceName;
        }
    }
}