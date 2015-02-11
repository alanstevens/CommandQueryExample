using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data
{
    // ReSharper disable InvokeAsExtensionMethod
    public class QueryExtensionsUtil : IQueryExtensionsUtil
    {
        public void OnStartup()
        {
            QueryExtensions.Util = this;
        }

        public async Task<bool> AllAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.AllAsync(collection, selector);
        }

        public async Task<bool> AllAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.AllAsync(collection, selector, cancellationToken);
        }

        public async Task<bool> AnyAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.AnyAsync(collection);
        }

        public async Task<bool> AnyAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.AnyAsync(collection, cancellationToken);
        }

        public async Task<bool> AnyAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.AnyAsync(collection, selector);
        }

        public async Task<bool> AnyAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.AnyAsync(collection, selector, cancellationToken);
        }

        public IQueryable<T> AsNoTracking<T>(IQueryable<T> collection) where T : class
        {
            return QueryableExtensions.AsNoTracking(collection);
        }

        public async Task ContainsAsync<T>(IQueryable<T> collection, T item) where T : class
        {
            await QueryableExtensions.ContainsAsync(collection, item);
        }

        public async Task<bool> ContainsAsync<T>(IQueryable<T> collection, T item, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ContainsAsync(collection, item, cancellationToken);
        }

        public async Task<int> CountAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.CountAsync(collection);
        }

        public async Task<int> CountAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.CountAsync(collection, cancellationToken);
        }

        public async Task<int> CountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.CountAsync(collection, selector);
        }

        public async Task<int> CountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.CountAsync(collection, selector, cancellationToken);
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

        public async Task<T> FirstAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.FirstAsync(collection);
        }

        public async Task<T> FirstAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.FirstAsync(collection, cancellationToken);
        }

        public async Task<T> FirstAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.FirstAsync(collection, selector);
        }

        public async Task<T> FirstAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.FirstAsync(collection, selector, cancellationToken);
        }

        public async Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.FirstOrDefaultAsync(collection);
        }

        public async Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.FirstOrDefaultAsync(collection, cancellationToken);
        }

        public async Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.FirstOrDefaultAsync(collection, selector);
        }

        public async Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.FirstOrDefaultAsync(collection, selector,cancellationToken);
        }

        public async Task ForEachAsync<T>(IQueryable<T> collection, Action<T> action) where T : class
        {
            await QueryableExtensions.ForEachAsync(collection, action);
        }

        public async Task ForEachAsync<T>(IQueryable<T> collection, Action<T> action, CancellationToken cancellationToken) where T : class
        {
            await QueryableExtensions.ForEachAsync(collection, action, cancellationToken);
        }

        public IQueryable<T> Include<T>(IQueryable<T> collection, string path) where T : class
        {
            return QueryableExtensions.Include(collection, path);
        }

        public IQueryable<T> Include<T, TProperty>(IQueryable<T> collection, Expression<Func<T, TProperty>> path) where T : class
        {
            return QueryableExtensions.Include(collection, path);
        }

        public void Load<T>(IQueryable<T> collection) where T : class
        {
            QueryableExtensions.Load(collection);
        }

        public async Task LoadAsync<T>(IQueryable<T> collection) where T : class
        {
            await QueryableExtensions.LoadAsync(collection);
        }

        public async Task LoadAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            await QueryableExtensions.LoadAsync(collection, cancellationToken);
        }

        public async Task<long> LongCountAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.LongCountAsync(collection);
        }

        public async Task<long> LongCountAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.LongCountAsync(collection, cancellationToken);
        }

        public async Task<long> LongCountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.LongCountAsync(collection, selector);
        }

        public async Task<long> LongCountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.LongCountAsync(collection, selector, cancellationToken);
        }

        public async Task<T> MaxAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.MaxAsync(collection);
        }

        public async Task<T> MaxAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.MaxAsync(collection, cancellationToken);
        }

        public async Task<TResult> MaxAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector) where T : class
        {
            return await QueryableExtensions.MaxAsync(collection, selector);
        }

        public async Task<TResult> MaxAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.MaxAsync(collection, selector, cancellationToken);
        }

        public async Task<T> MinAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.MinAsync(collection);
        }

        public async Task<T> MinAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.MinAsync(collection, cancellationToken);
        }

        public async Task<TResult> MinAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector) where T : class
        {
            return await QueryableExtensions.MinAsync(collection, selector);
        }

        public async Task<TResult> MinAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.MinAsync(collection, selector, cancellationToken);
        }

        public async Task<T> SingleAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.SingleAsync(collection);
        }

        public async Task<T> SingleAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.SingleAsync(collection, cancellationToken);
        }

        public async Task<T> SingleAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.SingleAsync(collection, selector);
        }

        public async Task<T> SingleAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.SingleAsync(collection, selector, cancellationToken);
        }

        public async Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.SingleOrDefaultAsync(collection);
        }

        public async Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.SingleOrDefaultAsync(collection, cancellationToken);
        }

        public async Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class
        {
            return await QueryableExtensions.SingleOrDefaultAsync(collection, selector);
        }

        public async Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.SingleOrDefaultAsync(collection, selector, cancellationToken);
        }

        public IQueryable<T> Skip<T>(IQueryable<T> collection, Expression<Func<int>> countAccessor) where T : class
        {
            return QueryableExtensions.Skip(collection, countAccessor);
        }

        public IQueryable<T> Take<T>(IQueryable<T> collection, Expression<Func<int>> countAccessor) where T : class
        {
            return QueryableExtensions.Take(collection, countAccessor);
        }

        public async Task<T[]> ToArrayAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.ToArrayAsync(collection);
        }

        public async Task<T[]> ToArrayAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ToArrayAsync(collection, cancellationToken);
        }

        public async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector);
        }

        public async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, cancellationToken);
        }

        public async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer ) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, comparer);
        }

        public async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer , CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, comparer, cancellationToken);
        }

        public async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, elementSelector);
        }

        public async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, elementSelector, cancellationToken);
        }

        public async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer ) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, elementSelector, comparer);
        }

        public async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer , CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ToDictionaryAsync(collection, keySelector, elementSelector, comparer, cancellationToken);
        }

        public async Task<IEnumerable<T>> ToListAsync<T>(IQueryable<T> collection) where T : class
        {
            return await QueryableExtensions.ToListAsync(collection);
        }

        public async Task<IEnumerable<T>> ToListAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await QueryableExtensions.ToListAsync(collection, cancellationToken);
        }

        static DbSet<T> GetSet<T>(IEnumerable<T> collection) where T : class
        {
            var set = collection as DbSet<T>;
            Verify.NotNull(set, "set");
            return set;
        }
    }
    // ReSharper restore InvokeAsExtensionMethod
}