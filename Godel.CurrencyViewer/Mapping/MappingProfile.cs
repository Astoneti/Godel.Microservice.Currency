using AutoMapper;
using Godel.Currency.Domain.Entities;
using Godel.CurrencyViewer.Business.Dto;
using Godel.CurrencyViewer.Data.Entities;

namespace Godel.Microservice.Currency.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CurrencyModel, CurrencyDto>().ReverseMap();
            CreateMap<CurrencyEntity, CurrencyDto>().ReverseMap();
            //CreateMap<List<CurrencyModel>, List<CurrencyDto>>().ReverseMap();???                                                                                              
            //CreateMap<List<CurrencyEntity>, List<CurrencyDto>>().ReverseMap();???
        }
    }
}
