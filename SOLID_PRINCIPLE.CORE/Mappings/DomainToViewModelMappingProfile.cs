namespace SOLID_PRINCIPLE.CORE.Mappings
{
    using AutoMapper;
    using ViewModels;
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