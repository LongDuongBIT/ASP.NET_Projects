using Abp.Application.Services;

namespace App
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AppAppServiceBase : ApplicationService
    {
        protected AppAppServiceBase()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }
    }
}