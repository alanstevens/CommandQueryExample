using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDbSetExtensionsUtil : IStartupTask
    {
        T Add<T>(IQueryable<T> collection, T entity) where T : class;

        IEnumerable<T> AddRange<T>(IQueryable<T> collection, IEnumerable<T> entities) where T : class;

        T Attach<T>(IQueryable<T> collection, T entity) where T : class;

        T Create<T>(IQueryable<T> collection) where T : class;

        TDerivedType Create<T, TDerivedType>(IQueryable<T> collection) where T : class where TDerivedType : class, T;

        T Find<T>(IQueryable<T> collection, params object[] keyValues) where T : class;

        Task<T> FindAsync<T>(IQueryable<T> collection, params object[] keyValues) where T : class;

        Task<T> FindAsync<T>(IQueryable<T> collection, CancellationToken cancellationToken, params object[] keyValues) where T : class;

        T Remove<T>(IQueryable<T> collection, T entity) where T : class;

        IEnumerable<T> RemoveRange<T>(IQueryable<T> collection, IEnumerable<T> entities) where T : class;

        IEnumerable<T> SqlQuery<T>(IQueryable<T> collection, string sql, params object[] parameters) where T : class;
    }
}