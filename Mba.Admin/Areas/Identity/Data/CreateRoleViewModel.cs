using System.ComponentModel.DataAnnotations;

namespace Mba.Admin.Areas.Identity.Data
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
