namespace SOLID_PRINCIPLE.SERVICEs.Interface
{
    using DATA.Models;
    using System.Collections.Generic;
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories(string name = null);
        Category GetCategory(int id);
        Category GetCategory(string name);
        void CreateCategory(Category category);
        void SaveCategory();
    }
}
