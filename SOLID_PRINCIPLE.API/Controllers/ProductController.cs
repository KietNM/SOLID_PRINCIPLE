namespace SOLID_PRINCIPLE.API.Controllers
{
    using DATA;
    using SERVICEs;
    using System.Collections.Generic;
    using System.Web.Http;
    public class ProductController : ApiController
    {
        private IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        public IEnumerable<Product> Get()
        {
            return _service.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var product = _service.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}