using System;
using System.Linq;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public abstract class AsyncScalarQueryBase<T>
    {
        protected Func<IQueryable<T>, Task<T>> _query;

        public async Task<T> CallAsync(IQueryable<T> set)
        {
            return await _query.Invoke(set);
        }
    }
}