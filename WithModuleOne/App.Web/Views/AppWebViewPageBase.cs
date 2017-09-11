using Abp.Web.Mvc.Views;

namespace App.Web.Views
{
    public abstract class AppWebViewPageBase : AppWebViewPageBase<dynamic>
    {

    }

    public abstract class AppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AppWebViewPageBase()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }
    }
}