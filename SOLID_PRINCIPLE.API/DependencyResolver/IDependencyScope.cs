namespace SOLID_PRINCIPLE.API.DependencyResolver
{
    using System;
    using System.Collections.Generic;
    public interface IDependencyScope : IDisposable
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}