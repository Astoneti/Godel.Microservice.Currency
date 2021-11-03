using Godel.CurrencyViewer.Business.Dto;
using System.Collections.Generic;

namespace Godel.CurrencyViewer.Business.Contracts
{
    public interface ICurrencyService
    {
        public List<CurrencyDto> GetList();
    }
}
