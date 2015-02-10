using System.Collections.Generic;
using System.Threading.Tasks;
using CommandQueryExample.Common.Commands;
using CommandQueryExample.Common.Queries;

namespace CommandQueryExample.Common
{
    public interface IDispatcher
    {
        IEnumerable<T> Get<T>(QueryBase<T> query) where T : class;

        Task<IEnumerable<T>> GetAsync<T>(AsyncQueryBase<T> query) where T : class;

        T Find<T>(ScalarQueryBase<T> query) where T : class;

        Task<T> FindAsync<T>(AsyncScalarQueryBase<T> query) where T : class;

        void QueueCommand<T>(CommandBase<T> command) where T : class;
    }
}