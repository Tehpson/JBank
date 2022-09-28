using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class Account
    {
        [Key]
        [Required]
        [MaxLength(12, ErrorMessage = "Acount Number need to be 12 characters")]
        [MinLength(12, ErrorMessage = "Acount Number need to be 12 characters")]
        public string AccountNumber { get; set; }

        [Required]
        public double Amount { get; set; } = 0;

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}