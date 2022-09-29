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

        public Loan? CreateLoan(User user, double Amount, double rentamount)
        {
            try
            {
                var UserCtx = context.Users.Find(user);
                if(UserCtx == null || Amount < 0 || rentamount < 0) return null;
                var newloan = new Loan { AmountLoaned = Amount, AmountPayedBack = 0, LeftToPay = Amount, Rent = rentamount };
                UserCtx.Loans.Add(newloan);
                context.SaveChanges();
                return context.Loans.Find(newloan);
            }
            catch 
            {
                return null;
            }
        }

        public Loan? GetLoanFromNumber(int LoanNumber)
        {
            return context.Loans.Find(LoanNumber);
        }

        public IEnumerable<Loan>? GetLoansFromUser(User user)
        {
            try
            {
                var userCtx = context.Users.Find(user);
                if (userCtx == null) return null;
                return userCtx.Loans;
            }
            catch 
            {
                return null;
            }
        }

        public bool IncreaseTotaltDueToRent()
        {
            try
            {
                foreach (var loan in context.Loans)
                {
                    loan.LeftToPay += loan.LeftToPay * loan.Rent;
                }
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool RePay(int loanNumber, double amount)
        {
            try
            {
                var loan = context.Loans.Find(loanNumber);
                if (loan == null || amount < 0) return false;
                loan.LeftToPay -= amount;
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpdateLeftToPay(int loanNumber, double newValue)
        {
            try
            {
                var loan = context.Loans.Find(loanNumber);
                if (loan == null || newValue < 0) return false;
                loan.LeftToPay = newValue;
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpdateRent(int loanNumber, double newRent)
        {
            try
            {
                var loan = context.Loans.Find(loanNumber);
                if (loan == null || newRent < 0) return false;
                loan.Rent = newRent;
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }

        }
    }
}