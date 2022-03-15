using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GuniThesis.Models
{
    public class MyIdentityUser : IdentityUser<Guid>
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} is Required")]
        [MinLength(2, ErrorMessage = "{0} requires minimum {1} characters")]
        [StringLength(50, ErrorMessage = "{0} cannot have more than {1} characters")]
        public string DisplayName { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required]
        [PersonalData]
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Gender")]
        [PersonalData]
        public MyIdentityGenders Gender { get; set; }  // enum to be created

        //role type :

        [Display(Name = "Is Admin User")]
        [Required]
        [MinLength(3)]
        [StringLength(60)]
        public string IsAdminUser { get; set; }
    }
}
