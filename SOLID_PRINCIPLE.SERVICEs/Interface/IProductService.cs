namespace SOLID_PRINCIPLE.SERVICEs
{
    using DATA;
    using System.Collections.Generic;
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}
