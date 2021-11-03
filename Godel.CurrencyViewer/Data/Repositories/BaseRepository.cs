using Godel.CurrencyViewer.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Godel.CurrencyViewer.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T>
        where T : class
    {
        protected DbContext DbContext { get; }

        public BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public List<T> GetList()
        {
            return DbContext.Set<T>().ToList();
        }
    }
}

