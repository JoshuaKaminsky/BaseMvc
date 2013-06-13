using BaseMvc.Data.Bolts;
using BaseMvc.Data.Bolts.Service;
using BaseMvc.Data.Contract;
using BaseMvc.Data.Foundry;
using Ninject.Modules;

namespace BaseMvc.Data.Bootstrap
{
    public class DataModule : NinjectModule
    {
        public override void Load()
        {
            Bind<RepositoryFactories>().To<RepositoryFactories>().InSingletonScope();

            Bind<IRepositoryProvider>().To<RepositoryProvider>();
            Bind<IUnitOfWork>().To<BaseUnitOfWork>();

            Bind<ISessionService>().To<SessionService>();
            Bind<IUserService>().To<UserService>();

            //Bind<IConnectionStringConfiguration>().To<AzureConnectionString>();
            //Bind<IImageStorage>().To<FileStystemImageStorage>();
        }
    }
}
