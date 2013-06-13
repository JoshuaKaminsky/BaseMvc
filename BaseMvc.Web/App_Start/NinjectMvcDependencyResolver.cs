using System.Web.Mvc;
using Ninject;

namespace BaseMvc.Web
{
    public class NinjectMvcDependencyResolver : NinjectDependencyScope, IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectMvcDependencyResolver(IKernel kernel)
            : base(kernel)
        {
            _kernel = kernel;
        }
    }
}