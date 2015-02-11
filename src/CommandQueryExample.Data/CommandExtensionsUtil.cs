using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data
{
    public class CommandExtensionsUtil : ICommandExtensionsUtil
    {
        public T Add<T>(IQueryable<T> collection, T item) where T : class
        {
            return GetSet(collection).Add(item);
        }

        public IEnumerable<T> AddMany<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return GetSet(collection).AddRange(items);
        }

        public T Delete<T>(IQueryable<T> collection, T item) where T : class
        {
            return GetSet(collection).Remove(item);
        }

        public IEnumerable<T> DeleteMany<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return GetSet(collection).RemoveRange(items);
        }

        public void OnStartup()
        {
            CommandExtensions.Util = this;
        }

        static DbSet<T> GetSet<T>(IEnumerable<T> collection) where T : class
        {
            var set = collection as DbSet<T>;
            Verify.NotNull(set, "set");
            return set;
        }
    }
}