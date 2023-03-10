using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTourManagementAPI.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int adminId { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get => FirstName; set => Password = value; }
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Email id cannot be null")]
        public string Email { get => Email; set => Email = value; }

        [Required(ErrorMessage = "Password cannot be null")]
        public string Password { get => Password; set => Password = value; }
        public long? PhoneNumber { get; set; }
        public string? Address { get; set; }
    }
}
