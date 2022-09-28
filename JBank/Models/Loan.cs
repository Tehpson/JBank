using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JBank.Models
{
    public class Loan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Required]
        public int LoanNumber { get; set; }

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