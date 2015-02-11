using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common.Extensions
{
    public static class AverageAsyncExtensions
    {
        public static IAverageAsyncExtensionsUtil Util { get; set; }
         
        public static async Task<double> AverageAsync(this IQueryable<int> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double> AverageAsync(this IQueryable<int> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double?> AverageAsync(this IQueryable<int?> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double?> AverageAsync(this IQueryable<int?> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double> AverageAsync(this IQueryable<long> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double> AverageAsync(this IQueryable<long> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double?> AverageAsync(this IQueryable<long?> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double?> AverageAsync(this IQueryable<long?> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double> AverageAsync(this IQueryable<float> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double> AverageAsync(this IQueryable<float> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double?> AverageAsync(this IQueryable<float?> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double?> AverageAsync(this IQueryable<float?> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double> AverageAsync(this IQueryable<double> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double> AverageAsync(this IQueryable<double> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double?> AverageAsync(this IQueryable<double?> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<double?> AverageAsync(this IQueryable<double?> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<decimal> AverageAsync(this IQueryable<decimal> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<decimal> AverageAsync(this IQueryable<decimal> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<decimal?> AverageAsync(this IQueryable<decimal?> collection)
        {
            return await Util.AverageAsync(collection);
        }

        public static async Task<decimal?> AverageAsync(this IQueryable<decimal?> collection, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, cancellationToken);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, int>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, int>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, int?>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, int?>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, long>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, long>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, long?>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, long?>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, float>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, float>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, float?>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, float?>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, double>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, double>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, double?>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<double?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, double?>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<decimal> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<decimal> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }

        public static async Task<decimal?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal?>> selector)
        {
            return await Util.AverageAsync(collection, selector);
        }

        public static async Task<decimal?> AverageAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal?>> selector, CancellationToken cancellationToken)
        {
            return await Util.AverageAsync(collection, selector, cancellationToken);
        }
    }
}