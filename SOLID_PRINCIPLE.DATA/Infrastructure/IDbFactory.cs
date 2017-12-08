using System;
namespace SOLID_PRINCIPLE.DATA.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        StoreEntities Init();
    }
}
