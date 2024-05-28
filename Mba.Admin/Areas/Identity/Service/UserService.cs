using Mba.Admin.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Mba.Admin.Areas.Identity.Service
{
    public class UserService
    {
        private readonly UserManager<MbaAdminUser> _userManager;

        public UserService(UserManager<MbaAdminUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<MbaAdminUser>> GetAllUserAsync()
        {
            return await _userManager.Users.ToListAsync();
        }
    }
}
