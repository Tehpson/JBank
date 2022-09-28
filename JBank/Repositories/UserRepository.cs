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

        public User AddUser()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int userNumber)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUser(int userNumber)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(int userNumber, User updateUser)
        {
            throw new NotImplementedException();
        }
    }
}