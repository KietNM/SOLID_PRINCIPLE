namespace SOLID_PRINCIPLE.DATA.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class GadgetConfiguration : EntityTypeConfiguration<Gadget>
    {
        public GadgetConfiguration()
        {
            ToTable("Gadgets", "Store");
            Property(g => g.Name).IsRequired().HasMaxLength(50);
            Property(g => g.Price).IsRequired().HasPrecision(10, 2);
            Property(g => g.CategoryID).IsRequired();
        }
    }
}
