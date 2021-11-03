using AutoMapper;
using Godel.CurrencyViewer.Business.Contracts;
using Godel.CurrencyViewer.Business.Dto;
using Godel.CurrencyViewer.Data.Contracts;
using Godel.CurrencyViewer.Data.Entities;
using System.Collections.Generic;

namespace Godel.CurrencyViewer.Business.Sevrices
{
    public class CurrencyService : ICurrencyService
    {
        public CurrencyService(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            this._currencyRepository = currencyRepository;
            this._mapper = mapper;
        }

        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public List<CurrencyDto> GetList()
        {
            var list = _currencyRepository.GetList();
            return _mapper.Map< List<CurrencyEntity> ,List<CurrencyDto>>(list);
        }
    }
}
