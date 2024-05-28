using System.ComponentModel.DataAnnotations;

namespace Mba.Admin.Areas.Identity.Data
{
    public class CreateUserRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string Username { get; set; }
    }
}
