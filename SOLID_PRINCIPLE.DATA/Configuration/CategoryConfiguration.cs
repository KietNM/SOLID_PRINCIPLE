namespace SOLID_PRINCIPLE.DATA.Configuration
{
    using Models;
    using System.Data.Entity.ModelConfiguration;
    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories", "Store");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
