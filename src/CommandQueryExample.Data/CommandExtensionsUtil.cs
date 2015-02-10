using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Data 
{
    public class CommandExtensionsUtil : ICommandExtensionsUtil, IStartupTask
    {
        public void OnStartup()
        {
            CommandExtensions.Util = this;
        }

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

        public T Delete<T>(IQueryable<T> collection, object key) where T : class
        {
            var set = GetSet(collection);
            var item = set.Find(key);
            Verify.NotNull(item, "item");
            return set.Remove(item);
        }

        public IEnumerable<T> DeleteMany<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class
        {
            return GetSet(collection).RemoveRange(items);
        }

        static DbSet<T> GetSet<T>(IEnumerable<T> collection) where T : class
        {
            var set = collection as DbSet<T>;
            Verify.NotNull(set, "set");
            return set;
        }
    }
}