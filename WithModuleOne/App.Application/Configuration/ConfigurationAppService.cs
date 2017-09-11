using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using App.Configuration.Dto;

namespace App.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
