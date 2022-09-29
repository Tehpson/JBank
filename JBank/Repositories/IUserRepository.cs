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
        User? GetUser(int userNumber);

        /// <summary>
        /// Create new User
        /// </summary>
        /// <returns>new User</returns>
        User? AddUser();

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
        User? UpdateUser(int userNumber, User updateUser);

        /// <summary>
        /// Updates the block vlaue for a user to take a loan
        /// </summary>
        /// <param name="user">the user to be update</param>
        /// <param name="updatedValue">true is want to be blocked false of not want to be blocked</param>
        /// <returns>if succsesfull</returns>
        bool UpdateLoanblock(User user, bool updatedValue);
    }
}