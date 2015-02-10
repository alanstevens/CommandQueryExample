using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IQueryExtensionsUtil
    {
        T Find<T>(IQueryable<T> collection, object id) where T : class;

        Task<T> FindAsync<T>(IQueryable<T> collection, object id) where T : class;

        Task<IEnumerable<T>> ToListAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> SingleAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class;

        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class;

        Task<T> FirstAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where = null) where T : class;

        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where = null) where T : class;

        IQueryable<T> Include<T>(IQueryable<T> collection, string path) where T : class;

        IQueryable<T> Include<T, P>(IQueryable<T> collection, Expression<Func<T, P>> path) where T : class;
    }
}