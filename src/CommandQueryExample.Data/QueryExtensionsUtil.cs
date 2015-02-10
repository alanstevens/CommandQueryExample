using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data
{
    public class QueryExtensionsUtil : IQueryExtensionsUtil, IStartupTask
    {
        public T Find<T>(IQueryable<T> collection, object id) where T : class
        {
            return GetSet(collection).Find(id);
        }

        public async Task<T> FindAsync<T>(IQueryable<T> collection, object id) where T : class
        {
            return await GetSet(collection).FindAsync(id);
        }

        public async Task<IEnumerable<T>> ToListAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.ToListAsync(collection);
        }

        public async Task<T> SingleAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await QueryableExtensions.SingleAsync(collection, where);
        }

        public async Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await QueryableExtensions.SingleOrDefaultAsync(collection, where);
        }

        public async Task<T> FirstAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where = null) where T : class
        {
            if (where == null)
                return await collection.FirstAsync();
            return await QueryableExtensions.FirstAsync(collection, where);
        }

        public async Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> where = null) where T : class
        {
            if (where == null)
                return await collection.FirstOrDefaultAsync();
            return await QueryableExtensions.FirstOrDefaultAsync(collection, where);
        }

        public IQueryable<T> Include<T>(IQueryable<T> collection, string path) where T : class
        {
            return QueryableExtensions.Include(collection, path);
        }

        public IQueryable<T> Include<T, P>(IQueryable<T> collection, Expression<Func<T, P>> path) where T : class
        {
            return QueryableExtensions.Include(collection, path);
        }

        public void OnStartup()
        {
            QueryExtensions.Util = this;
        }

        static DbSet<T> GetSet<T>(IEnumerable<T> collection) where T : class
        {
            var set = collection as DbSet<T>;
            Verify.NotNull(set, "set");
            return set;
        }
    }
}