using System.Collections.Generic;
using System.Linq;

namespace CommandQueryExample.Common.Extensions
{
    public static class CommandExtensions
    {
        public static ICommandExtensionsUtil Util { get; set; }

        public static T Add<T>(this IQueryable<T> collection, T item) where T : class
        {
            return Util.Add(collection, item);
        }

        public static IEnumerable<T> AddMany<T>(this IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return Util.AddMany(collection, items);
        }

        public static T Delete<T>(this IQueryable<T> collection, T item) where T : class
        {
            return Util.Delete(collection, item);
        }

        public static T Delete<T>(this IQueryable<T> collection, object key) where T : class
        {
            return Util.Delete(collection, key);
        }

        public static IEnumerable<T> DeleteMany<T>(this IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return Util.DeleteMany(collection, items);
        }
    }
}