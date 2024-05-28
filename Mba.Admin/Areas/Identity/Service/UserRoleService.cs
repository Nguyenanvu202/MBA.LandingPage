using Mba.Admin.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mba.Admin.Areas.Identity.Service
{
    public class UserRoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<MbaAdminUser> _userManager;

        public UserRoleService(RoleManager<IdentityRole> roleManager, UserManager<MbaAdminUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<List<UserRoleViewModel>> GetAllUserRole()
        {
            var userRole = new List<UserRoleViewModel>();

            var Users = await _userManager.Users.ToListAsync();
            var Roles = await _roleManager.Roles.ToListAsync();
            foreach (var user in Users)
            {
                foreach (var role in Roles)
                {
                    if(await _userManager.IsInRoleAsync(user, role.Name))
                    {
                        var userInNewModel = new UserRoleViewModel
                        {
                            RoleName = role.Name,
                            UserName = user.UserName,
                        };
                        userRole.Add(userInNewModel);
                    }
                }
            }
            return userRole;
        }

        public async Task<bool> CreateRoleForUserAsync(CreateUserRoleViewModel createUserRoleViewModel)
        {
            var userExist = await _userManager.Users.Where(x => x.UserName == createUserRoleViewModel.Username).FirstOrDefaultAsync();
            if (await _userManager.IsInRoleAsync(userExist, createUserRoleViewModel.RoleName))
            {
                return false;
            }
            await _userManager.AddToRoleAsync(userExist, createUserRoleViewModel.RoleName);
            return true;
        }
        public async Task<UserRoleViewModel> DeleteRoleForUser(UserRoleViewModel userRoleViewModel)
        {
            var userExist = await _userManager.Users.Where(x => x.UserName == userRoleViewModel.UserName).FirstOrDefaultAsync();
            await _userManager.RemoveFromRoleAsync(userExist, userRoleViewModel.RoleName);
            return userRoleViewModel;
        }

        public async Task<UserRoleViewModel> GetUserRoleById(string UserName, string RoleName)
        {
            var userRoles = await GetAllUserRole();
            var userRole = new UserRoleViewModel();
            foreach (var user in userRoles)
            {
                if(user.UserName == UserName && user.RoleName == RoleName)
                {
                    userRole = user;
                }
            }
            return userRole;
        }

        public async Task<bool> UpdateRoleForUser(string UserName, string UserRole, UserRoleViewModel userRoleViewModel)
        {
            var userExist = await _userManager.Users.Where(x => x.UserName == UserName).FirstOrDefaultAsync();
            if (!await _userManager.IsInRoleAsync(userExist, userRoleViewModel.RoleName))
            {
                await _userManager.RemoveFromRoleAsync(userExist, UserRole);
                await _userManager.AddToRoleAsync(userExist, userRoleViewModel.RoleName);
                return true;
            }

            return false;
        }
    }
}
