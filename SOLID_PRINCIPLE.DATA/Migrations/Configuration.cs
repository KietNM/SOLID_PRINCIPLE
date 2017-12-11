namespace SOLID_PRINCIPLE.DATA.Migrations
{
    using Seed;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<StoreEntities>
    {
        public Configuration()
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
