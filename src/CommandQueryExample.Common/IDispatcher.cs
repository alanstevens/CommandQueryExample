using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public interface IDispatcher
    {
        IEnumerable<T> Get<T>(BaseQuery<T> query) where T : class;

        Task<IEnumerable<T>> GetAsync<T>(BaseAsyncQuery<T> query) where T : class;

        T GetScaler<T>(BaseScalarQuery<T> query) where T : class;

        Task<T> GetScalerAsync<T>(BaseAsyncScalarQuery<T> query) where T : class;

        void QueueCommand<T>(CommandBase<T> command) where T : class;
    }
}