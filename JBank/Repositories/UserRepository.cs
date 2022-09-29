using JBank.Models;

namespace JBank.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BankDBContext context;

        public UserRepository(BankDBContext context)
        {
            this.context = context;
        }

        public User? AddUser(AreaCode areaCode)
        {
            try
            {
                var usernumber = new Guid();
                var user = new User { UserNumber = usernumber, AreaCode = areaCode, AbleToTakeLoan = true};
                context.Users.Add(user);
                context.SaveChanges();
                return GetUser(usernumber);
            }
            catch 
            {
                return null;
            }
        }

        public User? GetUser(Guid userNumber)
        {
            return context.Users.Find(userNumber);
        }

        public bool RemoveUser(Guid userNumber)
        {
            try
            {
                var userCtx = GetUser(userNumber);
                if (userCtx == null) return false;
                context.Users.Remove(userCtx);
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpadeAreaCode(Guid userNumber, AreaCode newAreaCode)
        {
            try
            {
                var userCtx = GetUser(userNumber);
                if (userCtx == null) return false;
                userCtx.AreaCode = newAreaCode;
                context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool UpdateLoanblock(Guid userNumber, bool updatedValue)
        {
            try
            {
                var userCtx = GetUser(userNumber);
                if (userCtx == null) return false;
                userCtx.AbleToTakeLoan = updatedValue;
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