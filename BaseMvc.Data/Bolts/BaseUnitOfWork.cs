using System;
using BaseMvc.Data.Contract;
using BaseMvc.Data.Entity;

namespace BaseMvc.Data.Bolts
{
    internal class BaseUnitOfWork : IUnitOfWork, IDisposable
    {
        private BaseDbContext _dbContext;

        public BaseUnitOfWork(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = _dbContext;
            RepositoryProvider = repositoryProvider;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }

        public IRepository<User> Users
        {
            get { return GetStandardRepo<User>(); }
        }

        public IRepository<Role> Roles
        {
            get { return GetStandardRepo<Role>(); }
        }

        public IRepository<Permission> Permissions
        {
            get { return GetStandardRepo<Permission>(); }
        }

        public IRepository<Session> Sessions
        {
            get { return GetStandardRepo<Session>(); }
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        protected void CreateDbContext()
        {
            _dbContext = new BaseDbContext();

            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
            _dbContext.Configuration.ValidateOnSaveEnabled = false;
            _dbContext.Configuration.AutoDetectChangesEnabled = false;
        }

        private IRepository<T> GetStandardRepo<T>() where T : BaseEntity
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }

        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
