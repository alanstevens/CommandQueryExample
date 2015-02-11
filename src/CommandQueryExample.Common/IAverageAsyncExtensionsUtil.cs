using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IAverageAsyncExtensionsUtil : IStartupTask
    {
        Task<double> AverageAsync(IQueryable<int> collection);

        Task<double> AverageAsync(IQueryable<int> collection, CancellationToken cancellationToken);

        Task<double?> AverageAsync(IQueryable<int?> collection);

        Task<double?> AverageAsync(IQueryable<int?> collection, CancellationToken cancellationToken);

        Task<double> AverageAsync(IQueryable<long> collection);

        Task<double> AverageAsync(IQueryable<long> collection, CancellationToken cancellationToken);

        Task<double?> AverageAsync(IQueryable<long?> collection);

        Task<double?> AverageAsync(IQueryable<long?> collection, CancellationToken cancellationToken);

        Task<double> AverageAsync(IQueryable<float> collection);

        Task<double> AverageAsync(IQueryable<float> collection, CancellationToken cancellationToken);

        Task<double?> AverageAsync(IQueryable<float?> collection);

        Task<double?> AverageAsync(IQueryable<float?> collection, CancellationToken cancellationToken);

        Task<double> AverageAsync(IQueryable<double> collection);

        Task<double> AverageAsync(IQueryable<double> collection, CancellationToken cancellationToken);

        Task<double?> AverageAsync(IQueryable<double?> collection);

        Task<double?> AverageAsync(IQueryable<double?> collection, CancellationToken cancellationToken);

        Task<decimal> AverageAsync(IQueryable<decimal> collection);

        Task<decimal> AverageAsync(IQueryable<decimal> collection, CancellationToken cancellationToken);

        Task<decimal?> AverageAsync(IQueryable<decimal?> collection);

        Task<decimal?> AverageAsync(IQueryable<decimal?> collection, CancellationToken cancellationToken);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int>> selector);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int>> selector, CancellationToken cancellationToken);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>> selector);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>> selector, CancellationToken cancellationToken);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long>> selector);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long>> selector, CancellationToken cancellationToken);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>> selector);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>> selector, CancellationToken cancellationToken);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float>> selector);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float>> selector, CancellationToken cancellationToken);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>> selector);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>> selector, CancellationToken cancellationToken);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double>> selector);

        Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double>> selector, CancellationToken cancellationToken);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>> selector);

        Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>> selector, CancellationToken cancellationToken);

        Task<decimal> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>> selector);

        Task<decimal> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>> selector, CancellationToken cancellationToken);

        Task<decimal?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>> selector);

        Task<decimal?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken);
    }
}