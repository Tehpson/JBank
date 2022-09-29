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

        public Transaction? AddIncomingTransaction(int accountNumber, int formAccont, double amount)
        {
            try
            {
                Account acc = GetAccount(accountNumber);
                if (acc == null || amount < 0)
                {
                    return null;
                }
                var transaction = new Transaction { Amount = amount, ToAccount = accountNumber, FromAccount = formAccont, Time = DateTime.Now };
                acc.Transactions.Add(transaction);
                context.SaveChanges();
                return context.Transactions.Find(transaction);
            }
            catch
            {
                return null;
            }
        }

        public Transaction? AddOutgoingTransaction(int accountNumber, int toAccount, double amount)
        {
            try
            {
                Account acc = GetAccount(accountNumber);
                if (acc == null || amount < 0)
                {
                    return null;
                }
                var transaction = new Transaction { Amount = amount, ToAccount = toAccount, FromAccount = accountNumber, Time = DateTime.Now };
                acc.Transactions.Add(transaction);
                context.SaveChanges();
                return context.Transactions.Find(transaction);
            }
            catch
            {
                return null;
            }
        }

        public Account? CreateAccount(User user)
        {
            try
            {
                var userCtx = context.Users.Find(user);
                if (userCtx == null)
                {
                    return null;
                }

                string accountnumber;
                var areaCodeNumber = (int)userCtx.AreaCode;
                var areaCodeSplit = areaCodeNumber.ToString().ToCharArray();
                accountnumber =
                    areaCodeSplit.Length == 3 ?
                        (areaCodeNumber * 10 + new Random().Next(10)).ToString()
                    : areaCodeSplit.Length == 2 ?
                        "0" + (areaCodeNumber * 10 + new Random().Next(10)).ToString()
                    : areaCodeSplit.Length == 1 ?
                        "00" + (areaCodeNumber * 10 + new Random().Next(10)).ToString() :
                        new Random().Next(1000, 10000).ToString();
                accountnumber += DateTime.Now.ToString("yyMMddmmff");

                var acc = new Account { AccountNumber = accountnumber, Amount = 0};

                userCtx.Accounts.Add(acc);
                context.SaveChanges();
                return context.Accounts.Find(acc);
            }
            catch
            {
                return null;
            }
        }

        public Account? GetAccount(int accountNumber)
        {
            return context.Accounts.Find(accountNumber);
        }

        public IEnumerable<Account>? GetAccounts(User user)
        {
            try
            {
                var DBUser = context.Users.Find(user);
                return DBUser?.Accounts;
            }
            catch 
            {
                return null;
            }
        }

        public bool RemoveAccount(int acountNumber)
        {
            try
            {
                var acc = context.Accounts.Find(acountNumber);
                if(acc == null) return false;
                context.Accounts.Remove(acc);
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