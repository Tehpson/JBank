using JBank.Models;
using System.Linq.Expressions;

namespace JBank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankDBContext context;

        public AccountRepository(BankDBContext context)
        {
            this.context = context;
        }

        public bool AddIncomingTransaction(int accountNumber, int formAccont, double amount)
        {
            try
            {
                Account acc = GetAccount(accountNumber);
                if(acc == null || amount < 0)
                {
                    return false;
                }
                var transaction = new Transaction { Amount = amount, ToAccount = accountNumber, FromAccount = formAccont, Time = DateTime.Now };
                acc.Transactions.Add(transaction);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddOutgoingTransaction(int accountNumber, int ToAccount, double amount)
        {
            try
            {
                Account acc = GetAccount(accountNumber);
                if (acc == null || amount < 0)
                {
                    return false;
                }
                var transaction = new Transaction { Amount = amount, ToAccount = ToAccount, FromAccount = accountNumber, Time = DateTime.Now };
                acc.Transactions.Add(transaction);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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