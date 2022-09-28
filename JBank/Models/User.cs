using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class User
    {
        [Key]
        [Required]
        public Guid UserNumber { get; set; }

        public List<Account> Accounts { get; set; }

        [Required]
        public bool AbleToTakeLoan { get; set; } = true;

        public List<Loan> Loan { get; set; } = new List<Loan>();
    }
}