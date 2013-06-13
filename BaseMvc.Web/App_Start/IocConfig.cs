using System.Web.Http;
using System.Web.Mvc;
using BaseMvc.Data.Bootstrap;
using BaseMvc.Web.Bootstrap;
using Ninject;
using Ninject.Modules;

namespace BaseMvc.Web
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(new NinjectModule[] { new WebModule(), new DataModule() });

            DependencyResolver.SetResolver(new NinjectMvcDependencyResolver(kernel));
        }
    }
}