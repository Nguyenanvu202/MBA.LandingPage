using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Repository
{
    public interface IUserRepo
    {
        Task<User> FindUserAsync(string username, string pass);
    }
}
