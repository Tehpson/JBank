using JBank.Models;

namespace JBank.Repositories
{
    internal interface IUserRepository
    {
        /// <summary>
        /// Get an user
        /// </summary>
        /// <param name="userNumber">number of user</param>
        /// <returns></returns>
        User GetUser(int userNumber);

        /// <summary>
        /// Create new User
        /// </summary>
        /// <returns>new User</returns>
        User AddUser();

        /// <summary>
        /// Remove User
        /// </summary>
        /// <param name="userNumber">Number of user</param>
        /// <returns>if succsessfull</returns>
        bool RemoveUser(int userNumber);

        /// <summary>
        /// Updates an exisitng user
        /// </summary>
        /// <param name="userNumber">numer of user to be updated</param>
        /// <param name="updateUser">Updated values of user </param>
        /// <returns>updated user</returns>
        User UpdateUser(int userNumber, User updateUser);
    }
}