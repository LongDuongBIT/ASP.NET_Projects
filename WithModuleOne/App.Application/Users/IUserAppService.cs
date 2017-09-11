using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using App.Roles.Dto;
using App.Users.Dto;

namespace App.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}