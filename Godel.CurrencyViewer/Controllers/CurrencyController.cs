using AutoMapper;
using Godel.Currency.Domain.Entities;
using Godel.CurrencyViewer.Business.Contracts;
using Godel.CurrencyViewer.Business.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Godel.CurrencyViewer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        public CurrencyController(ILogger<CurrencyController> logger, ICurrencyService currencyService, IMapper mapper)
        {
            _logger = logger;
            _currencyService = currencyService;
            _mapper = mapper;
        }

        private readonly ILogger<CurrencyController> _logger;
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        [HttpGet]
        public IEnumerable<CurrencyModel> Get()
        {
            var list = _currencyService.GetList();
            return _mapper.Map<List<CurrencyDto>,List<CurrencyModel>>(list);            
        }
    }
}
