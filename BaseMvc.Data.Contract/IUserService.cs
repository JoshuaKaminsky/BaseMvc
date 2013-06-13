using BaseMvc.Model;

namespace BaseMvc.Data.Contract
{
    public interface IUserService
    {
        User GetUser(string userName, string password);

        User GetUserById(int userId);

        User CreateUser(string userName, string password, string firstName, string lastName);

        User UpdateUser(User user);

        bool DeactivateUser(int userId);
    }
}
