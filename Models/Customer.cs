using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Gym.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [DisplayName("Phone Number")]

        public string PhoneNumber { get; set; }
        [DisplayName("Date of Birth")]
        public DateOnly DOB { get; set; }
        [DisplayName("User Name")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Email daal mc")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        
        public int PIN { get; set; }
        public string Gender {  get; set; }
        [DisplayName("Date Of Resgistration")]
        public DateOnly DateOfResgistration{ get; set; }
        public double BMI { get; set; }
    }
}
