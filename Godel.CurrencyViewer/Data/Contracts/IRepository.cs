using System.Collections.Generic;

namespace Godel.CurrencyViewer.Data.Contracts
{
    public interface IRepository<T>
    {
        public List<T> GetList();        
    }
}
