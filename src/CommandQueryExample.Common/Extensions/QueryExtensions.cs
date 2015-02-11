using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common.Extensions
{
    public static class QueryExtensions
    {
        public static IQueryExtensionsUtil Util { get; set; }

        public static async Task<bool> AllAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, T item) where T : class
        {
            return await Util.AllAsync(collection, where);
        }

        public static async Task<bool> AllAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, T item, CancellationToken cancellationToken) where T : class
        {
            return await Util.AllAsync(collection, where, cancellationToken);
        }

        public static async Task<bool> AnyAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.AnyAsync(collection);
        }

        public static async Task<bool> AnyAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.AnyAsync(collection, cancellationToken);
        }

        public static async Task<bool> AnyAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.AnyAsync(collection, where);
        }

        public static async Task<bool> AnyAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.AnyAsync(collection, where, cancellationToken);
        }

        public static IQueryable<T> AsNoTracking<T>(this IQueryable<T> collection) where T : class
        {
            return Util.AsNoTracking(collection);
        }

        public static async Task ContainsAsync<T>(this IQueryable<T> collection, T item) where T : class
        {
            await Util.ContainsAsync(collection, item);
        }

        public static async Task<bool> ContainsAsync<T>(this IQueryable<T> collection, T item, CancellationToken cancellationToken) where T : class
        {
            return await Util.ContainsAsync(collection, item, cancellationToken);
        }

        public static async Task<int> CountAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.CountAsync(collection);
        }

        public static async Task<int> CountAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.CountAsync(collection, cancellationToken);
        }

        public static async Task<int> CountAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.CountAsync(collection, where);
        }

        public static async Task<int> CountAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.CountAsync(collection, where, cancellationToken);
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

        public static async Task<T> FirstAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.FirstAsync(collection);
        }

        public static async Task<T> FirstAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.FirstAsync(collection, cancellationToken);
        }

        public static async Task<T> FirstAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.FirstAsync(collection, where);
        }

        public static async Task<T> FirstAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.FirstAsync(collection, where, cancellationToken);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> collection) where T : class
        {
                return await Util.FirstOrDefaultAsync(collection);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.FirstOrDefaultAsync(collection, cancellationToken);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.FirstOrDefaultAsync(collection, where);
        }

        public static async Task<T> FirstOrDefaultAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.FirstOrDefaultAsync(collection, where,cancellationToken);
        }

        public static async Task ForEachAsync<T>(this IQueryable<T> collection, Action<T> action) where T : class
        {
            await Util.ForEachAsync(collection, action);
        }

        public static async Task ForEachAsync<T>(this IQueryable<T> collection, Action<T> action, CancellationToken cancellationToken) where T : class
        {
            await Util.ForEachAsync(collection, action, cancellationToken);
        }

        public static IQueryable<T> Include<T>(this IQueryable<T> collection, string path) where T : class
        {
            return Util.Include(collection, path);
        }

        public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> collection, Expression<Func<T, TProperty>> path) where T : class
        {
            return Util.Include(collection, path);
        }

        public static void Load<T>(this IQueryable<T> collection) where T : class
        {
            Util.Load(collection);
        }

        public static async Task LoadAsync<T>(this IQueryable<T> collection) where T : class
        {
            await Util.LoadAsync(collection);
        }

        public static async Task LoadAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            await Util.LoadAsync(collection, cancellationToken);
        }

        public static async Task<long> LongCountAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.LongCountAsync(collection);
        }

        public static async Task<long> LongCountAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.LongCountAsync(collection, cancellationToken);
        }

        public static async Task<long> LongCountAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.LongCountAsync(collection, where);
        }

        public static async Task<long> LongCountAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.LongCountAsync(collection, where, cancellationToken);
        }

        public static async Task<T> MaxAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.MaxAsync(collection);
        }

        public static async Task<T> MaxAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.MaxAsync(collection, cancellationToken);
        }

        public static async Task<TResult> MaxAsync<T, TResult>(this IQueryable<T> collection, Expression<Func<T, TResult>> where) where T : class
        {
            return await Util.MaxAsync(collection, where);
        }

        public static async Task<TResult> MaxAsync<T, TResult>(this IQueryable<T> collection, Expression<Func<T, TResult>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.MaxAsync(collection, where, cancellationToken);
        }

        public static async Task<T> MinAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.MinAsync(collection);
        }

        public static async Task<T> MinAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.MinAsync(collection, cancellationToken);
        }

        public static async Task<TResult> MinAsync<T, TResult>(this IQueryable<T> collection, Expression<Func<T, TResult>> where) where T : class
        {
            return await Util.MinAsync(collection, where);
        }

        public static async Task<TResult> MinAsync<T, TResult>(this IQueryable<T> collection, Expression<Func<T, TResult>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.MinAsync(collection, where, cancellationToken);
        }

        public static async Task<T> SingleAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.SingleAsync(collection);
        }

        public static async Task<T> SingleAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.SingleAsync(collection, cancellationToken);
        }

        public static async Task<T> SingleAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.SingleAsync(collection, where);
        }

        public static async Task<T> SingleAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.SingleAsync(collection, where, cancellationToken);
        }

        public static async Task<T> SingleOrDefaultAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.SingleOrDefaultAsync(collection);
        }

        public static async Task<T> SingleOrDefaultAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.SingleOrDefaultAsync(collection, cancellationToken);
        }

        public static async Task<T> SingleOrDefaultAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where) where T : class
        {
            return await Util.SingleOrDefaultAsync(collection, where);
        }

        public static async Task<T> SingleOrDefaultAsync<T>(this IQueryable<T> collection, Expression<Func<T, bool>> where, CancellationToken cancellationToken) where T : class
        {
            return await Util.SingleOrDefaultAsync(collection, where, cancellationToken);
        }

        public static IQueryable<T> Skip<T>(this IQueryable<T> collection, Expression<Func<int>> countAccesor) where T : class
        {
            return Util.Skip(collection, countAccesor);
        }

        public static IQueryable<T> Take<T>(this IQueryable<T> collection, Expression<Func<int>> countAccesor) where T : class
        {
            return Util.Take(collection, countAccesor);
        }

        public static async Task<T[]> ToArrayAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.ToArrayAsync(collection);
        }

        public static async Task<T[]> ToArrayAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.ToArrayAsync(collection, cancellationToken);
        }

        public static async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(this IQueryable<T> collection, Func<T, TKey> keySelector) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector);
        }

        public static async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(this IQueryable<T> collection, Func<T, TKey> keySelector, CancellationToken cancellationToken) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, cancellationToken);
        }

        public static async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(this IQueryable<T> collection, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer ) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, comparer);
        }

        public static async Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(this IQueryable<T> collection, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer , CancellationToken cancellationToken) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, comparer, cancellationToken);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(this IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, elementSelector);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(this IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, CancellationToken cancellationToken) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, elementSelector, cancellationToken);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(this IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer ) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, elementSelector, comparer);
        }

        public static async Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(this IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer , CancellationToken cancellationToken) where T : class
        {
            return await Util.ToDictionaryAsync(collection, keySelector, elementSelector, comparer, cancellationToken);
        }

        public static async Task<IEnumerable<T>> ToListAsync<T>(this IQueryable<T> collection) where T : class
        {
            return await Util.ToListAsync(collection);
        }

        public static async Task<IEnumerable<T>> ToListAsync<T>(this IQueryable<T> collection, CancellationToken cancellationToken) where T : class
        {
            return await Util.ToListAsync(collection, cancellationToken);
        }
    }
}