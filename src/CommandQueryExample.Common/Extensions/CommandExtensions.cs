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

        public static IEnumerable<T> AddRange<T>(this IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return Util.AddRange(collection, items);
        }

        public static T Remove<T>(this IQueryable<T> collection, T item) where T : class
        {
            return Util.Remove(collection, item);
        }

        public static IEnumerable<T> RemoveRange<T>(this IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return Util.RemoveRange(collection, items);
        }
    }
}