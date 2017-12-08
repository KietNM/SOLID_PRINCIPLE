using SOLID_PRINCIPLE.DATA.Models;
using System.Data.Entity.ModelConfiguration;

namespace SOLID_PRINCIPLE.DATA.Configuration
{
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories", "Store");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
