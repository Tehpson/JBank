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
        User? GetUser(Guid userNumber);

        /// <summary>
        /// Create new User
        /// </summary>
        /// <param name="areaCode">AreaCode of user</param>
        /// <returns>new User</returns>
        User? AddUser(AreaCode areaCode);

        /// <summary>
        /// Remove User
        /// </summary>
        /// <param name="userNumber">Number of user</param>
        /// <returns>if succsessfull</returns>
        bool RemoveUser(Guid userNumber);

        /// <summary>
        /// Updates area code of a user
        /// </summary>
        /// <param name="userNumber">numer of user to be updated</param>
        /// <param name="newAreaCode">new AreaCode of user</param>
        /// <returns>if successfull</returns>
        bool UpadeAreaCode(Guid userNumber, AreaCode newAreaCode);

        /// <summary>
        /// Updates the block vlaue for a user to take a loan
        /// </summary>
        /// <param name="user">the user to be update</param>
        /// <param name="updatedValue">true is want to be blocked false of not want to be blocked</param>
        /// <returns>if succsesfull</returns>
        bool UpdateLoanblock(Guid userNumber, bool updatedValue);
    }
}