using SOLID_PRINCIPLE.DATA;
using System.Collections.Generic;

namespace SOLID_PRINCIPLE.SERVICEs
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}
