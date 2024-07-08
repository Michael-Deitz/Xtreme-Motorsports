using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Xtreme.Models.DTOs

{
    public class UserProfileForVehiclesDTO
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [NotMapped]
        public string UserName { get; set; }
        [NotMapped]
        public string PhoneNumber { get; set; }
        [NotMapped]
        public string Email { get; set; }
        public string FullName
        {
            get
            {
                return$"{FirstName} {LastName}";
            }
        }
    }

}