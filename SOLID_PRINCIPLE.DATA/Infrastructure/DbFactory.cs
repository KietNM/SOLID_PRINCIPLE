namespace SOLID_PRINCIPLE.DATA.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        StoreEntities dbContext;

        public StoreEntities Init()
        {
            return dbContext ?? (dbContext = StoreEntities.Create());
        }

        protected override void DisposeCore()
        {
           if(dbContext!=null)
                dbContext.Dispose();
        }
    }
}
