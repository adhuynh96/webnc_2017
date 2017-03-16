using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using WebAdvance.Assignment.Core.Interfaces;
using WebAdvance.Assignment.EntityFramework;
using WebAdvance.Assignment.EntityFramework.Repositories;

namespace WebAdvance.Assignment.App_Start
{
    public class ContainerConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<DatabaseContext>().InstancePerRequest();

            builder.RegisterType<TesterRepository>().As<ITesterRepository>().InstancePerRequest();
           
            builder.RegisterType<EfUnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}