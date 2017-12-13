namespace SOLID_PRINCIPLE.SERVICEs
{
    using DATA;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ProductService : IProductService
    {
        private AdventureWorks2012Entities db = new AdventureWorks2012Entities();

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }
        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(p => p.ProductID == id);
        }
        public void Add(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
