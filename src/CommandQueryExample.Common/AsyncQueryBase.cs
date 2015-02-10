using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public abstract class AsyncQueryBase<T> where T : class
    {
        protected Func<IQueryable<T>, Task<IEnumerable<T>>> _query;

        public async Task<IEnumerable<T>> CallAsync(IQueryable<T> set)
        {
            return await _query.Invoke(set);
        }
    }
}