using SOLID_PRINCIPLE.SERVICEs;
using System.Web.Http;
using Unity;
using Unity.Lifetime;

namespace SOLID_PRINCIPLE.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver.UnityResolver(container);
           
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
