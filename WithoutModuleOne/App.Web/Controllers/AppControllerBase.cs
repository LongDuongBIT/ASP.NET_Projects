using Abp.Web.Mvc.Controllers;

namespace App.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AppControllerBase : AbpController
    {
        protected AppControllerBase()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }
    }
}