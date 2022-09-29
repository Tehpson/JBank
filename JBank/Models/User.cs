using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class User
    {
        [Key]
        [Required]
        public Guid UserNumber { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();

        [Required]
        public bool AbleToTakeLoan { get; set; } = true;

        public List<Loan> Loans { get; set; } = new List<Loan>();

        public AreaCode AreaCode { get; set; }
    }
}