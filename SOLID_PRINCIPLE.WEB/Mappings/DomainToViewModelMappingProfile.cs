namespace SOLID_PRINCIPLE.WEB.Mappings
{
    using AutoMapper;
    using CORE.ViewModels;
    using DATA.Models;
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        public DomainToViewModelMappingProfile()
        {
           CreateMap<Category, CategoryViewModel>();
           CreateMap<Gadget, GadgetViewModel>();
        }
    }
}