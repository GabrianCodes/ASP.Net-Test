using System.ComponentModel.DataAnnotations;

namespace Discussion.Models
{
    public class User
    {
        [Key] // Denotes Primary Key
        public int Id { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        public string Email { get; set; } // Email will be the display name

        [Required]
        [Display(Name = "Registration Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
    }
}
