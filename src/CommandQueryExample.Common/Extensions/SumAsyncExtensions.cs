using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common.Extensions
{
    public static class SumAsyncExtensions
    {
        public static ISumAsyncExtensionsUtil Util { get; set; }
         
        public static async Task<int> SumAsync(this IQueryable<int> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<int> SumAsync(this IQueryable<int> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<int?> SumAsync(this IQueryable<int?> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<int?> SumAsync(this IQueryable<int?> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<long> SumAsync(this IQueryable<long> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<long> SumAsync(this IQueryable<long> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<long?> SumAsync(this IQueryable<long?> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<long?> SumAsync(this IQueryable<long?> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<float> SumAsync(this IQueryable<float> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<float> SumAsync(this IQueryable<float> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<float?> SumAsync(this IQueryable<float?> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<float?> SumAsync(this IQueryable<float?> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<double> SumAsync(this IQueryable<double> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<double> SumAsync(this IQueryable<double> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<double?> SumAsync(this IQueryable<double?> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<double?> SumAsync(this IQueryable<double?> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<decimal> SumAsync(this IQueryable<decimal> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<decimal> SumAsync(this IQueryable<decimal> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<decimal?> SumAsync(this IQueryable<decimal?> collection)
        {
            return await Util.SumAsync(collection);
        }

        public static async Task<decimal?> SumAsync(this IQueryable<decimal?> collection, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, cancellationToken);
        }

        public static async Task<int> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, int>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<int> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, int>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<int?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, int?>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<int?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, int?>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<long> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, long>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<long> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, long>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<long?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, long?>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<long?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, long?>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<float> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, float>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<float> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, float>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<float?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, float?>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<float?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, float?>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<double> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, double>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<double> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, double>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<double?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, double?>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<double?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, double?>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<decimal> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<decimal> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }

        public static async Task<decimal?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal?>>  selector)
        {
            return await Util.SumAsync(collection, selector);
        }

        public static async Task<decimal?> SumAsync<T>(this IQueryable<T> collection, Expression<Func<T, decimal?>>  selector, CancellationToken cancellationToken)
        {
            return await Util.SumAsync(collection, selector, cancellationToken);
        }
    }
}