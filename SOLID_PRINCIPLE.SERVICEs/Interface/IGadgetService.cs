namespace SOLID_PRINCIPLE.SERVICEs.Interface
{
    using DATA.Models;
    using System.Collections.Generic;
    public interface IGadgetService
    {
        IEnumerable<Gadget> GetGadgets();
        IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null);
        Gadget GetGadget(int id);
        void CreateGadget(Gadget gadget);
        void SaveGadget();
    }
}
