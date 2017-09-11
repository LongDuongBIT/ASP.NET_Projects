using System.Threading.Tasks;
using Abp.Application.Services;
using App.Sessions.Dto;

namespace App.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
