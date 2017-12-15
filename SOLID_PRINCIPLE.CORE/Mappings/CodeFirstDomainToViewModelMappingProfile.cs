namespace SOLID_PRINCIPLE.CORE.Mappings
{
    using AutoMapper;
    using ViewModels;
    using DATA;

    public class CodeFirstDomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "CodeFirstDomainToViewModelMappingProfile"; }
        }
        public CodeFirstDomainToViewModelMappingProfile()
        {
           CreateMap<Product, ProductViewModel>();                             
        }
    }
}