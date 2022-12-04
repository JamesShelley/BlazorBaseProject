using AutoMapper;
using BlazorBusiness.Core.Models.CommonModels.CRM;
using BlazorBusiness.Domain.Entities.CRM;

namespace BlazorBusiness.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {   
            CreateMap<ContactViewModel, Contact>().ReverseMap();
            CreateMap<ContactFormSubmission, Contact>().ReverseMap();
        }
    }
}
