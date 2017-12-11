using SOLID_PRINCIPLE.DATA.Models;
using System.Data.Entity.ModelConfiguration;

namespace SOLID_PRINCIPLE.DATA.Configuration
{
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
