using System.Collections.Generic;
using System.Linq;

namespace CommandQueryExample.Common
{
    public interface ICommandExtensionsUtil : IStartupTask
    {
        T Add<T>(IQueryable<T> collection, T item) where T : class;

        IEnumerable<T> AddRange<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class;

        T Remove<T>(IQueryable<T> collection, T item) where T : class;

        IEnumerable<T> RemoveRange<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class;
    }
}