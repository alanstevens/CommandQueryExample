using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common.Extensions
{
    public static class DbSetExtensions
    {
        public static IDbSetExtensionsUtil Util { get; set; }
         
        public static T Add<T>(this IQueryable<T> collection, T entity) where T : class
        {
            return Util.Add(collection, entity);
        }

        public static IEnumerable<T> AddRange<T>(this IQueryable<T> collection, IEnumerable<T> entities) where T : class
        {
            return Util.AddRange(collection, entities);
        }

        public static T Attach<T>(this IQueryable<T> collection, T entity) where T : class
        {
            return Util.Attach(collection, entity);
        }

        public static T Create<T>(this IQueryable<T> collection) where T : class
        {
            return Util.Create(collection);
        }

        public static TDerivedType Create<T, TDerivedType>(this IQueryable<T> collection) where T : class where TDerivedType : class, T
        {
            return Util.Create<T, TDerivedType>(collection);
        }

        public static T Find<T>(this IQueryable<T> collection, params object[] keyValues) where T : class
        {
            return Util.Find(collection, keyValues);
        }

        public static async Task<T> FindAsync<T>(this IQueryable<T> collection, params object[] keyValues) where T : class
        {
            return await Util.FindAsync(collection, keyValues);
        }

        public static async Task<T> FindAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken, params object[] keyValues) where T : class
        {
            return await Util.FindAsync(collection, cancellationToken, keyValues);
        }

        public static T Remove<T>(this IQueryable<T> collection, T entity) where T : class
        {
            return Util.Remove(collection, entity);
        }

        public static IEnumerable<T> RemoveRange<T>(this IQueryable<T> collection, IEnumerable<T> entities) where T : class
        {
            return Util.RemoveRange(collection, entities);
        }

        public static IEnumerable<T> SqlQuery<T>(this IQueryable<T> collection, string sql, params object[] parameters) where T : class
        {
            return Util.SqlQuery(collection, sql, parameters);
        }
    }
}