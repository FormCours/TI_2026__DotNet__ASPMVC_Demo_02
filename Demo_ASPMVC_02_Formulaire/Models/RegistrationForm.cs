using System.ComponentModel.DataAnnotations;

namespace Demo_ASPMVC_02_Formulaire.Models
{
    public class RegistrationForm
    {
        [Required]
        [MinLength(3)]
        [Display(Name="Nom:")]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(1, 10)]
        public int NbPerson { get; set; }
    }
}
