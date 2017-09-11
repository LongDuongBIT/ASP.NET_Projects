using System.Collections.Generic;
using App.Roles.Dto;
using App.Users.Dto;

namespace App.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}