using System.Collections.Generic;
using WeixinProject.Roles.Dto;
using WeixinProject.Users.Dto;

namespace WeixinProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
