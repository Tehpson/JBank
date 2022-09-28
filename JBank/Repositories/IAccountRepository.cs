using JBank.Models;

namespace JBank.Repositories
{
    internal interface IAccountRepository
    {
        /// <summary>
        /// Get account using number
        /// </summary>
        /// <param name="accountNumber">number of the account</param>
        /// <returns>an account</returns>
        Account GetAccount(int accountNumber);

        /// <summary>
        /// Get All account a user have
        /// </summary>
        /// <param name="user">user of the accounts</param>
        /// <returns>list of accounts</returns>
        IEnumerable<Account> GetAccounts(User user);

        /// <summary>
        /// Create new Accrount
        /// </summary>
        /// <param name="user">user who wants new account</param>
        /// <returns>New account</returns>
        Account CreateAccount(User user);

        /// <summary>
        /// Add an Transaction
        /// </summary>
        /// <param name="accountNumber">number of account sent from</param>
        /// <param name="ToAccount">number of account sent to</param>
        /// <param name="amount">amount sent</param>
        /// <returns></returns>
        Transaction Addtransaction(int accountNumber, int ToAccount, double amount);

        /// <summary>
        /// Removes an account
        /// </summary>
        /// <param name="acountNumber">accountNumber to be removed</param>
        /// <returns>if succssesfull</returns>
        bool RemoveAccount(int acountNumber);
    }
}