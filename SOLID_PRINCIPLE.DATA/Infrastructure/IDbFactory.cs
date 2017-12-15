namespace SOLID_PRINCIPLE.DATA.Infrastructure
{
    using System;
    public interface IDbFactory : IDisposable
    {
        StoreEntities Init();
    }
}
