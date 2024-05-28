using Core.Models.Entity;
using Core.Models.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly MBAContext _mBAContext;

        public UserRepo(MBAContext mBAContext)
        {
            _mBAContext = mBAContext;
        }
        public async Task<User> FindUserAsync(string username, string pass)
        {
            var existUser = await _mBAContext.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == pass );
            if (existUser == null)
            {
                return null;
            }
            return existUser;
        }
    }
}
