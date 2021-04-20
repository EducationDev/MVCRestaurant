using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MVCRestaurant.Data.Services;

namespace MVCRestaurant.Site
{
    public class ContainerConfig
    {

        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            // ## RegisterType
            builder.RegisterType<InMemoryRestaurantData>().As<IRestaurantData>().SingleInstance();
            // ## RegisterType


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}