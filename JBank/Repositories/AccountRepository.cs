using JBank.Models;

namespace JBank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankDBContext context;

        public AccountRepository(BankDBContext context)
        {
            this.context = context;
        }

        public Transaction Addtransaction(int accountNumber, int ToAccount, double amount)
        {
            throw new NotImplementedException();
        }

        public Account CreateAccount(User user)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(int accountNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAccounts(User user)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAccount(int acountNumber)
        {
            throw new NotImplementedException();
        }
    }
}