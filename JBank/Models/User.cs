using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class User
    {
        [Key]
        [Required]
        [MaxLength(20, ErrorMessage = "User number need to be 20 characters")]
        [MinLength(20, ErrorMessage = "user number need to be 20 characters")]
        public int UserNumber { get; set; }

        [Required]
        public List<Account> Accounts { get; set; }

        [Required]
        public bool AbleToTakeLoan { get; set; } = true;

        public List<Loan> Loan { get; set; } = new List<Loan>();
    }
}