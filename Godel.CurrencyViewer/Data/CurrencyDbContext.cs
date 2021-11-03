using Godel.CurrencyViewer.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Godel.CurrencyViewer.Data
{
    public class CurrencyDbContext : DbContext
    {
        public DbSet<CurrencyEntity> Currencies { get; set; }

        public CurrencyDbContext(DbContextOptions<CurrencyDbContext> options)
         : base(options)
        {
        }
    }
}
