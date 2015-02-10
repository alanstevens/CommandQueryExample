using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IQueryExtensionsUtil : IStartupTask
    {
        Task<bool> AllAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<bool> AllAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        Task<bool> AnyAsync<T>(IQueryable<T> collection) where T : class;

        Task<bool> AnyAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<bool> AnyAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<bool> AnyAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        IQueryable<T> AsNoTracking<T>(IQueryable<T> collection) where T : class;

        Task ContainsAsync<T>(IQueryable<T> collection, T item) where T : class;

        Task<bool> ContainsAsync<T>(IQueryable<T> collection, T item, CancellationToken cancellationToken) where T : class;

        Task<int> CountAsync<T>(IQueryable<T> collection) where T : class;

        Task<int> CountAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<int> CountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<int> CountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        T Find<T>(IQueryable<T> collection, params object[] keyValues) where T : class;

        Task<T> FindAsync<T>(IQueryable<T> collection, params object[] keyValues) where T : class;

        Task<T> FindAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken, params object[] keyValues) where T : class;

        Task<T> FirstAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> FirstAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<T> FirstAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<T> FirstAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<T> FirstOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        Task ForEachAsync<T>(IQueryable<T> collection, Action<T> action) where T : class;

        Task ForEachAsync<T>(IQueryable<T> collection, Action<T> action, CancellationToken cancellationToken) where T : class;

        IQueryable<T> Include<T>(IQueryable<T> collection, string path) where T : class;

        IQueryable<T> Include<T, TProperty>(IQueryable<T> collection, Expression<Func<T, TProperty>> path) where T : class;

        void Load<T>(IQueryable<T> collection) where T : class;

        Task LoadAsync<T>(IQueryable<T> collection) where T : class;

        Task LoadAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<long> LongCountAsync<T>(IQueryable<T> collection) where T : class;

        Task<long> LongCountAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<long> LongCountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<long> LongCountAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        Task<T> MaxAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> MaxAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<TResult> MaxAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector) where T : class;

        Task<TResult> MaxAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector, CancellationToken cancellationToken) where T : class;

        Task<T> MinAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> MinAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<TResult> MinAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector) where T : class;

        Task<TResult> MinAsync<T, TResult>(IQueryable<T> collection, Expression<Func<T, TResult>> selector, CancellationToken cancellationToken) where T : class;

        Task<T> SingleAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> SingleAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<T> SingleAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<T> SingleAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection) where T : class;

        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector) where T : class;

        Task<T> SingleOrDefaultAsync<T>(IQueryable<T> collection, Expression<Func<T, bool>> selector, CancellationToken cancellationToken) where T : class;

        IQueryable<T> Skip<T>(IQueryable<T> collection, Expression<Func<int>> countAccessor) where T : class;

        IQueryable<T> Take<T>(IQueryable<T> collection, Expression<Func<int>> countAccessor) where T : class;

        Task<T[]> ToArrayAsync<T>(IQueryable<T> collection) where T : class;

        Task<T[]> ToArrayAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;

        Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector) where T : class;

        Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector, CancellationToken cancellationToken) where T : class;

        Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer ) where T : class;

        Task<Dictionary<TKey, T>> ToDictionaryAsync<T, TKey>(IQueryable<T> collection, Func<T, TKey> keySelector, IEqualityComparer<TKey> comparer , CancellationToken cancellationToken) where T : class;

        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector) where T : class;

        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, CancellationToken cancellationToken) where T : class;

        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer ) where T : class;

        Task<Dictionary<TKey, TElement>> ToDictionaryAsync<T, TKey, TElement>(IQueryable<T> collection, Func<T, TKey> keySelector, Func<T, TElement> elementSelector, IEqualityComparer<TKey> comparer , CancellationToken cancellationToken) where T : class;

        Task<IEnumerable<T>> ToListAsync<T>(IQueryable<T> collection) where T : class;

        Task<IEnumerable<T>> ToListAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken) where T : class;
    }
}