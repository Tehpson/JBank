using System.ComponentModel.DataAnnotations;

namespace JBank.Models
{
    public class Loan
    {
        [Key]
        [Required]
        public uint LoanNumber { get; set; }

        [Required]
        public double AmountLoaned { get; set; }

        [Required]
        public double AmountPayedBack { get; set; }

        [Required]
        public double Rent { get; set; }

        [Required]
        public double LeftToPay { get; set; }
    }
}