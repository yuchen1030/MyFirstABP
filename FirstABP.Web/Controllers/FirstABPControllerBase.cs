using Abp.Web.Mvc.Controllers;

namespace FirstABP.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class FirstABPControllerBase : AbpController
    {
        protected FirstABPControllerBase()
        {
            LocalizationSourceName = FirstABPConsts.LocalizationSourceName;
        }
    }
}