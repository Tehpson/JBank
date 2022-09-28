using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class Account
    {
        [Key]
        [Required]
        [MaxLength(14, ErrorMessage = "Acount Number need to be 14 characters")]
        [MinLength(14, ErrorMessage = "Acount Number need to be 14 characters")]
        public string AccountNumber { get; set; }

        [Required]
        public double Amount { get; set; } = 0;

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}