using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SOLID_PRINCIPLE.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Init database
            // System.Data.Entity.Database.SetInitializer((new DbSeed());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
