using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLID_PRINCIPLE.API.DependencyResolver
{
    public interface IDependencyScope : IDisposable
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}