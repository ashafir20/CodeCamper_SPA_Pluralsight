using System.Web.Http;
using CodeCamper.Contracts;
using CodeCamper.Data;
using CodeCamper.Data.Helpers;
using Ninject;

namespace CodeCamper
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            var kernel = new StandardKernel(); //Ninject IoC

            kernel.Bind<ICodeCamperUow>().To<CodeCamperUow>();
            kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            kernel.Bind<RepositoryFactories>().To<RepositoryFactories>().InSingletonScope();

            config.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}