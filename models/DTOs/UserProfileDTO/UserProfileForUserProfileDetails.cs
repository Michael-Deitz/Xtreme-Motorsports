using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Xtreme.Models.DTOs;
public class UserProfileForUserProfileDetailsDTO
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [NotMapped]
    public string UserName { get; set; }

    [NotMapped]
    public string Email { get; set; }

    public DateTime DateCreated { get; set; }

    [DataType(DataType.Url)]
    [MaxLength(255)]
    public string ImageLocation { get; set; }
    public byte[]? ImageBlob { get; set; }

    [NotMapped]
    public List<string> Roles { get; set; }
    [NotMapped]
    public string PhoneNumber { get; set; }

    public string IdentityUserId { get; set; }

    public IdentityUser IdentityUser { get; set; }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    public string FormattedDateCreated => DateCreated.Date.ToString("MM-dd-yyyy");
}