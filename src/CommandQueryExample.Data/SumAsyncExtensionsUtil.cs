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
    public partial class SumAsyncExtensionsUtil : ISumAsyncExtensionsUtil
    {
        public async Task<int> SumAsync(IQueryable<int> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<int> SumAsync(IQueryable<int> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<int?> SumAsync(IQueryable<int?> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<int?> SumAsync(IQueryable<int?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<long> SumAsync(IQueryable<long> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<long> SumAsync(IQueryable<long> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<long?> SumAsync(IQueryable<long?> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<long?> SumAsync(IQueryable<long?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<float> SumAsync(IQueryable<float> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<float> SumAsync(IQueryable<float> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<float?> SumAsync(IQueryable<float?> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<float?> SumAsync(IQueryable<float?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<double> SumAsync(IQueryable<double> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<double> SumAsync(IQueryable<double> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<double?> SumAsync(IQueryable<double?> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<double?> SumAsync(IQueryable<double?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<decimal> SumAsync(IQueryable<decimal> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<decimal> SumAsync(IQueryable<decimal> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<decimal?> SumAsync(IQueryable<decimal?> collection)
        {
            return await QueryableExtensions.SumAsync(collection);
        }

        public async Task<decimal?> SumAsync(IQueryable<decimal?> collection, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, cancellationToken);
        }

        public async Task<int> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<int> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<int?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<int?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, int?>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<long> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<long> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<long?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<long?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, long?>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<float> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<float> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<float?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<float?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, float?>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<double> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<double> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<double?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<double?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, double?>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<decimal> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<decimal> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public async Task<decimal?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>>  selector)
        {
            return await QueryableExtensions.SumAsync(collection, selector);
        }

        public async Task<decimal?> SumAsync<T>(IQueryable<T> collection, Expression<Func<T, decimal?>>  selector, CancellationToken cancellationToken)
        {
            return await QueryableExtensions.SumAsync(collection, selector, cancellationToken);
        }

        public void OnStartup()
        {
            SumAsyncExtensions.Util = this;
        }
    }
    // ReSharper restore InvokeAsExtensionMethod
}