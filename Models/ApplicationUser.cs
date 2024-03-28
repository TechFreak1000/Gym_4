using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class ApplicationUser : IdentityUser
    {

        public required string FullName { get; set; }
        public DateOnly? DOB { get; set; }
        public DateOnly? DOR { get; set; }
        public string? Gender { get; set; }
        public string? BMI { get; set; }

    }
}
