namespace SOLID_PRINCIPLE.WEB.Controllers
{
    using AutoMapper;
    using CORE.ViewModels;
    using DATA;
    using SERVICEs;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            IEnumerable<ProductViewModel> viewModelProducts;
            IEnumerable<Product> products;
            products = productService.GetAll().ToList();
            viewModelProducts = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(viewModelProducts);            
        }
    }
}