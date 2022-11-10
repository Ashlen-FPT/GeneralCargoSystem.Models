using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralCargoSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [NotMapped]
        public string Role { get; set; } = string.Empty;

        public byte[]? UserImage { get; set; }
        public bool UserStatus { get; set; }
        public DateTime CreatedOnDateTime { get; set; }
    }
}
