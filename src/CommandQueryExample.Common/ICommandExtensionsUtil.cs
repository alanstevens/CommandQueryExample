using System.Collections.Generic;
using System.Linq;

namespace CommandQueryExample.Common
{
    public interface ICommandExtensionsUtil : IStartupTask
    {
        T Add<T>(IQueryable<T> collection, T item) where T : class;

        IEnumerable<T> AddMany<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class;

        T Delete<T>(IQueryable<T> collection, T item) where T : class;

        IEnumerable<T> DeleteMany<T>(IQueryable<T> collection, IEnumerable<T> items) where T : class;
    }
}