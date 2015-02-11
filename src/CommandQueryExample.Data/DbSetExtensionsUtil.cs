using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data
{
    public class DbSetExtensionsUtil : IDbSetExtensionsUtil
    {
        public T Add<T>(IQueryable<T> collection, T entity) where T : class
        {
            return GetSet(collection).Add(entity);
        }

        public IEnumerable<T> AddRange<T>(IQueryable<T> collection, IEnumerable<T> entities) where T : class
        {
            return GetSet(collection).AddRange(entities);
        }

        public T Attach<T>(IQueryable<T> collection, T entity) where T : class
        {
            return GetSet(collection).Attach(entity);
        }

        public T Create<T>(IQueryable<T> collection) where T : class
        {
            return GetSet(collection).Create();
        }

        public TDerivedType Create<T, TDerivedType>(IQueryable<T> collection) where T : class where TDerivedType : class, T
        {
            return GetSet(collection).Create<TDerivedType>();
        }

        public T Find<T>(IQueryable<T> collection, params object[] keyValues) where T : class
        {
            return GetSet(collection).Find(keyValues);
        }

        public async Task<T> FindAsync<T>(IQueryable<T> collection, params object[] keyValues) where T : class
        {
            return await GetSet(collection).FindAsync(keyValues);
        }

        public async Task<T> FindAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken, params object[] keyValues) where T : class
        {
            return await GetSet(collection).FindAsync(cancellationToken, keyValues);
        }

        public T Remove<T>(IQueryable<T> collection, T entity) where T : class
        {
            return GetSet(collection).Remove(entity);
        }

        public IEnumerable<T> RemoveRange<T>(IQueryable<T> collection, IEnumerable<T> entities) where T : class
        {
            return GetSet(collection).RemoveRange(entities);
        }

        public IEnumerable<T> SqlQuery<T>(IQueryable<T> collection, string sql, params object[] parameters) where T : class
        {
            return GetSet(collection).SqlQuery(sql, parameters);
        }

        public void OnStartup()
        {
            DbSetExtensions.Util = this;
        }

        static DbSet<T> GetSet<T>(IEnumerable<T> collection) where T : class
        {
            var set = collection as DbSet<T>;
            Verify.NotNull(set, "set");
            return set;
        }
    }
}