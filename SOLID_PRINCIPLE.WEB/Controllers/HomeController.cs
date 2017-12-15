namespace SOLID_PRINCIPLE.WEB.Controllers
{
    using AutoMapper;
    using CORE.Results;
    using CORE.ViewModels;
    using DATA.Models;
    using SERVICEs.Interface;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using SHAREDLIBs;
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IGadgetService gadgetService;
        private readonly IFileService fileService;     
        public HomeController(ICategoryService categoryService, IGadgetService gadgetService, IFileService fileService)
        {
            this.categoryService = categoryService;
            this.gadgetService = gadgetService;
            this.fileService = fileService;
        }

        // GET: Home
        public ActionResult Index(string category = null)
        {
            IEnumerable<CategoryViewModel> viewModelGadgets;
            IEnumerable<Category> categories;

            categories = categoryService.GetCategories(category).ToList();

            viewModelGadgets = Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(viewModelGadgets);
        }

        public ActionResult Filter(string category, string gadgetName)
        {
            IEnumerable<GadgetViewModel> viewModelGadgets;
            IEnumerable<Gadget> gadgets;

            gadgets = gadgetService.GetCategoryGadgets(category, gadgetName);

            viewModelGadgets = Mapper.Map<IEnumerable<Gadget>, IEnumerable<GadgetViewModel>>(gadgets);

            return View(viewModelGadgets);
        }

        [HttpPost]
        public ActionResult Create(GadgetFormViewModel newGadget)
        {
            if (newGadget != null && newGadget.File != null)
            {
                var gadget = Mapper.Map<GadgetFormViewModel, Gadget>(newGadget);
                gadgetService.CreateGadget(gadget);

                string sFileName = string.Empty;
                var rsSaveFileResult = fileService.SaveFileToDir(newGadget.File, FileResource.DirPath, out sFileName);
                switch (rsSaveFileResult)
                {
                    case ActionServiceResult.Succeed:
                        {
                            gadgetService.SaveGadget();
                        }
                        break;
                    case ActionServiceResult.Failed:
                        return Json(new
                        {
                        success = false,
                        code = HttpStatusCodes.NOT_MODIFIED,
                        data = ActionServiceResult.Failed
                        },JsonRequestBehavior.DenyGet);
                }
            }

            var category = categoryService.GetCategory(newGadget.GadgetCategory);
            return RedirectToAction("Index", new { category = category.Name });
        }
    }
}