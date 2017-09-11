using System.Threading.Tasks;
using Abp.Application.Services;
using App.Authorization.Accounts.Dto;

namespace App.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
