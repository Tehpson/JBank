using JBank.Models;

namespace JBank.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly BankDBContext context;

        public LoanRepository(BankDBContext context)
        {
            this.context = context;
        }

        public Loan? CreateLoan(User user)
        {
            throw new NotImplementedException();
        }

        public Loan? GetLoanFromNumber(int LoanNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Loan>? GetLoansFromUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool IncreaseTotaltDueToRent()
        {
            throw new NotImplementedException();
        }

        public bool RePay(int loanNumber, double amount)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRent(int loanNumber, double newRent)
        {
            throw new NotImplementedException();
        }
    }
}