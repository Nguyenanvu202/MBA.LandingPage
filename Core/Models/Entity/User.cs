using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
    public class User : BaseEntity
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string Comment { get; set; } = "";
        public List<string> Roles { get; set; } = new();


    }
}
