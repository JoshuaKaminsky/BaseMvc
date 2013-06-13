using BaseMvc.Data.Entity;

namespace BaseMvc.Data.Contract
{
    internal interface IUnitOfWork
    {
        void Commit();

        void Rollback();

        IRepository<User> Users { get; }

        IRepository<Role> Roles { get; }
        
        IRepository<Permission> Permissions { get; }
        
        IRepository<Session> Sessions { get; }
    }
}
