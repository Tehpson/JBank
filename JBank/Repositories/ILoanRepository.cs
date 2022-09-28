using JBank.Models;

namespace JBank.Repositories
{
    internal interface ILoanRepository
    {
        /// <summary>
        /// Get Loan by loanNumber
        /// </summary>
        /// <param name="LoanNumber">number of loan</param>
        /// <returns> one loan object</returns>
        Loan GetLoanFromNumber(int LoanNumber);

        /// <summary>
        /// Gets all loan from a user
        /// </summary>
        /// <param name="user">user who have loans</param>
        /// <returns> list of loans</returns>
        IEnumerable<Loan> GetLoansFromUser(User user);

        /// <summary>
        /// Create New Loan
        /// </summary>
        /// <param name="user">user who is geting loan</param>
        /// <returns>Loan That was created</returns>
        Loan CreateLoan(User user);

        /// <summary>
        /// Add amount that was Repaied
        /// </summary>
        /// <param name="loanNumber">number of the loan</param>
        /// <param name="amount">amount to be added</param>
        /// <returns>if succsessfull</returns>
        bool RePay(int loanNumber, double amount);

        /// <summary>
        /// Updates the vlue of rent
        /// </summary>
        /// <param name="loanNumber">number of the loan</param>
        /// <param name="newRent">new rent value</param>
        /// <returns>if sucssesfull</returns>
        bool UpdateRent(int loanNumber, double newRent);

        /// <summary>
        /// Update total to pay back due to rent
        /// </summary>
        /// <returns>of succsessfull</returns>
        bool IncreaseTotaltDueToRent();
    }
}