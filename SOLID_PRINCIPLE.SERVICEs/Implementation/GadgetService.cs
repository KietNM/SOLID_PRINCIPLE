﻿namespace SOLID_PRINCIPLE.SERVICEs.Implementation
{
    using DATA.Infrastructure;
    using DATA.Models;
    using DATA.Repositories;
    using Interface;
    using System.Collections.Generic;
    using System.Linq;
    public class GadgetService : IGadgetService
    {
        private readonly IGadgetRepository gadgetsRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public GadgetService(IGadgetRepository gadgetsRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.gadgetsRepository = gadgetsRepository;
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IGadgetService Members

        public IEnumerable<Gadget> GetGadgets()
        {
            var gadgets = gadgetsRepository.GetAll();
            return gadgets;
        }

        public IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null)
        {
            var category = categoryRepository.GetCategoryByName(categoryName);
            return category.Gadgets.Where(g => g.Name.ToLower().Contains(gadgetName.ToLower().Trim()));
        }

        public Gadget GetGadget(int id)
        {
            var gadget = gadgetsRepository.GetById(id);
            return gadget;
        }

        public void CreateGadget(Gadget gadget)
        {
            gadgetsRepository.Add(gadget);          
        }

        public void SaveGadget()
        {
            unitOfWork.Commit();
        }

        #endregion
    }
}
