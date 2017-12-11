namespace SOLID_PRINCIPLE.CORE.ViewModels
{
    using System.Collections.Generic;
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public List<GadgetViewModel> Gadgets { get; set; }
    }
}
