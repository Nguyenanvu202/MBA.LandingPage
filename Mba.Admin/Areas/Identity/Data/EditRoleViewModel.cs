using System.ComponentModel.DataAnnotations;

namespace Mba.Admin.Areas.Identity.Data
{
    public class EditRoleViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required(ErrorMessage = "Role Name is Required")]
        public string RoleName { get; set; } = string.Empty;
    }
}
