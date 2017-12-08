using SOLID_PRINCIPLE.DATA.Seed;
using System.Data.Entity.Migrations;

namespace SOLID_PRINCIPLE.DATA.Migrations
{
    internal sealed class MigrationsConfiguration : DbMigrationsConfiguration<StoreEntities>
    {
        public MigrationsConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StoreEntities context)
        {
            DbSeed.GetCategories().ForEach(c => context.Categories.Add(c));
            DbSeed.GetGadgets().ForEach(c => context.Gadgets.Add(c));
            context.Commit();
        }
    }
}
