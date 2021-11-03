using Godel.CurrencyViewer.Data.Contracts;
using Godel.CurrencyViewer.Data.Entities;

namespace Godel.CurrencyViewer.Data.Repositories
{
    public class CurrencyRepository : BaseRepository<CurrencyEntity>, ICurrencyRepository
    {
        public CurrencyRepository(CurrencyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
