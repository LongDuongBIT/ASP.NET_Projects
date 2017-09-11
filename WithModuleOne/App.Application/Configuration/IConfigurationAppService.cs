using System.Threading.Tasks;
using Abp.Application.Services;
using App.Configuration.Dto;

namespace App.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}