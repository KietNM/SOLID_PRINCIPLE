namespace SOLID_PRINCIPLE.API.DependencyResolver
{
    using System;
    public interface IDependencyResolver : IDependencyScope, IDisposable
    {
        IDependencyScope BeginScope();
    }
}