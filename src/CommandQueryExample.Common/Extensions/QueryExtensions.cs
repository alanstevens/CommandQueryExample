using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CommandQueryExample.Common.Extensions
{
    // TODO: HAS 02/09/2015 Add the rest of the async methods on DbSet
    public static class QueryExtensions
    {
        public static IQueryExtensionsUtil Util { get; set; }

        public static T Find<T>(this IQueryable<T> collection, object id) where T : class
        {
            return Util.Find(collection, id);
        }

        public static async Task<T> FindAsync<T>(this IQueryable<T> collection, object id) where T : class
        {
            return await Util.FindAsync(collection, id);
        }

        public static async Task<IEnumerable<T>> ToListAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.ToListAsync(collection);
        }

        public static async Task<T> SingleAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.SingleAsync(collection, where);
        }

        public static async Task<T> SingleOrDefaultAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.SingleOrDefaultAsync(collection, where);
        }

        public static async Task<T> FirstAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where = null) where T : class
        {
            return await Util.FirstAsync(collection, where);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where = null) where T : class
        {
            return await Util.FirstOrDefaultAsync(collection, where);
        }

        public static IQueryable<T> Include<T>(this IQueryable<T> collection, string path) where T : class
        {
            return Util.Include(collection, path);
        }

        public static IQueryable<T> Include<T, P>(this IQueryable<T> collection, Expression<Func<T, P>> path) where T : class
        {
            return Util.Include(collection, path);
        }
    }
}