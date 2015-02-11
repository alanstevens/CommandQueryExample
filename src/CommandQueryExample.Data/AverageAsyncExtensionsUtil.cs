using System;
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
    public class AverageAsyncExtensionsUtil : IAverageAsyncExtensionsUtil
    {
        public async Task<double> AverageAsync(IQueryable<int> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double> AverageAsync(IQueryable<int> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double?> AverageAsync(IQueryable<int?> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double?> AverageAsync(IQueryable<int?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double> AverageAsync(IQueryable<long> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double> AverageAsync(IQueryable<long> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double?> AverageAsync(IQueryable<long?> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double?> AverageAsync(IQueryable<long?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double> AverageAsync(IQueryable<float> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double> AverageAsync(IQueryable<float> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double?> AverageAsync(IQueryable<float?> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double?> AverageAsync(IQueryable<float?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double> AverageAsync(IQueryable<double> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double> AverageAsync(IQueryable<double> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double?> AverageAsync(IQueryable<double?> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<double?> AverageAsync(IQueryable<double?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<decimal> AverageAsync(IQueryable<decimal> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<decimal> AverageAsync(IQueryable<decimal> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<decimal?> AverageAsync(IQueryable<decimal?> collection)
        {
            return await QueryableExtensions.AverageAsync(collection);
        }

        public async Task<decimal?> AverageAsync(IQueryable<decimal?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, cancellationToken);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<double?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<decimal> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<decimal> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public async Task<decimal?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>> selector)
        {
            return await QueryableExtensions.AverageAsync(collection, selector);
        }

        public async Task<decimal?> AverageAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.AverageAsync(collection, selector, cancellationToken);
        }

        public void OnStartup()
        {
            AverageAsyncExtensions.Util = this;
        }
    }
    // ReSharper restore InvokeAsExtensionMethod
}