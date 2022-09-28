using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int FromAccount { get; set; }

        [Required]
        public int ToAccount { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public double Amount { get; set; }
    }
}