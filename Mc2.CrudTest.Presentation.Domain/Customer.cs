using System.ComponentModel.DataAnnotations;

namespace Mc2.CrudTest.Presentation.Domain
{
    public class Customer
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Date Of Birth is required")]
        public DateTime DateOfBirth { get; set; }
        [MaxLength (50)]
        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [Key]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Bank Account Number is required")]
        public string BankAccountNumber { get; set; }
    }
}