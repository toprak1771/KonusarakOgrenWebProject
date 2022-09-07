using System.ComponentModel.DataAnnotations;

namespace KonusarakOgrenWebProject.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Lütfen rol ismi giriniz")]
        [Display(Name = "Role ismi")]
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
