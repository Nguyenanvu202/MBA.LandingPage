using Mba.Admin.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mba.Admin.Areas.Identity.Service
{
    public class RoleService
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleService(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<List<IdentityRole>> GetAllRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<EditRoleViewModel> GetRoleByIdAsync(string id)
        {
            var roleDb =  await _roleManager.FindByIdAsync(id);
            EditRoleViewModel role = new EditRoleViewModel();
            {
                role.Id = roleDb.Id;
                roleDb.Name = roleDb.Name;
            }

            return role;
        }

        public async Task<IdentityRole> DeleteRoleAsync(string id)
        {
            var existRole = await _roleManager.Roles.FirstOrDefaultAsync(x => x.Id == id);
            if (existRole != null)
            {
                 await _roleManager.DeleteAsync(existRole);
            }
            else
            {
                return existRole;
            }
            return existRole;
        }

        public async Task<IdentityRole> UpdateRoleAsync(string id, EditRoleViewModel role)
        {
            var existRole = await _roleManager.Roles.FirstOrDefaultAsync(i => i.Id == id);
            if (existRole != null)
            {
                existRole.Id = role.Id;
                existRole.Name = role.RoleName;
            }
            else
            {
                return null;
            }
            return existRole;
        }

        public async Task<IdentityRole> CreateRoleAsync(CreateRoleViewModel role)
        {
            IdentityRole identityRole = new IdentityRole();
            identityRole.Name = role.RoleName ?? string.Empty;
            var roleExist = await _roleManager.RoleExistsAsync(identityRole.Name);
            if(roleExist != null)
            {
                await _roleManager.CreateAsync(identityRole);
            }
            else
            {
                return null;
            }
            return identityRole;
        }
    }
}
