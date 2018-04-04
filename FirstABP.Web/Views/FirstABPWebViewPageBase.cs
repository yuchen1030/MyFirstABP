using Abp.Web.Mvc.Views;

namespace FirstABP.Web.Views
{
    public abstract class FirstABPWebViewPageBase : FirstABPWebViewPageBase<dynamic>
    {

    }

    public abstract class FirstABPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FirstABPWebViewPageBase()
        {
            LocalizationSourceName = FirstABPConsts.LocalizationSourceName;
        }
    }
}