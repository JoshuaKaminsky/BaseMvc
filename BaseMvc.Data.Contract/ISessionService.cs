using System;
using BaseMvc.Model;

namespace BaseMvc.Data.Contract
{
    public interface ISessionService
    {
        Session Login(int userId);

        bool Logout(int userId);

        bool IsValid(int userId, Guid sessionId);
    }
}
