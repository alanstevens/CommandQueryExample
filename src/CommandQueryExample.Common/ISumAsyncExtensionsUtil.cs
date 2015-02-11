using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface ISumAsyncExtensionsUtil : IStartupTask
    {
        Task<int> SumAsync(IQueryable<int> collection);

        Task<int> SumAsync(IQueryable<int> collection, CancellationToken cancellationToken);

        Task<int?> SumAsync(IQueryable<int?> collection);

        Task<int?> SumAsync(IQueryable<int?> collection, CancellationToken cancellationToken);

        Task<long> SumAsync(IQueryable<long> collection);

        Task<long> SumAsync(IQueryable<long> collection, CancellationToken cancellationToken);

        Task<long?> SumAsync(IQueryable<long?> collection);

        Task<long?> SumAsync(IQueryable<long?> collection, CancellationToken cancellationToken);

        Task<float> SumAsync(IQueryable<float> collection);

        Task<float> SumAsync(IQueryable<float> collection, CancellationToken cancellationToken);

        Task<float?> SumAsync(IQueryable<float?> collection);

        Task<float?> SumAsync(IQueryable<float?> collection, CancellationToken cancellationToken);

        Task<double> SumAsync(IQueryable<double> collection);

        Task<double> SumAsync(IQueryable<double> collection, CancellationToken cancellationToken);

        Task<double?> SumAsync(IQueryable<double?> collection);

        Task<double?> SumAsync(IQueryable<double?> collection, CancellationToken cancellationToken);

        Task<decimal> SumAsync(IQueryable<decimal> collection);

        Task<decimal> SumAsync(IQueryable<decimal> collection, CancellationToken cancellationToken);

        Task<decimal?> SumAsync(IQueryable<decimal?> collection);

        Task<decimal?> SumAsync(IQueryable<decimal?> collection, CancellationToken cancellationToken);

        Task<int> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int>> selector);

        Task<int> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int>> selector, CancellationToken cancellationToken);

        Task<int?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>> selector);

        Task<int?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>> selector, CancellationToken cancellationToken);

        Task<long> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long>> selector);

        Task<long> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long>> selector, CancellationToken cancellationToken);

        Task<long?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>> selector);

        Task<long?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>> selector, CancellationToken cancellationToken);

        Task<float> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float>> selector);

        Task<float> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float>> selector, CancellationToken cancellationToken);

        Task<float?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>> selector);

        Task<float?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>> selector, CancellationToken cancellationToken);

        Task<double> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double>> selector);

        Task<double> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double>> selector, CancellationToken cancellationToken);

        Task<double?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>> selector);

        Task<double?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>> selector, CancellationToken cancellationToken);

        Task<decimal> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>> selector);

        Task<decimal> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>> selector, CancellationToken cancellationToken);

        Task<decimal?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>> selector);

        Task<decimal?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken);
    }
}