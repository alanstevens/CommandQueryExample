using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public abstract class BaseAsyncQuery<T> where T : class
    {
        protected Func<IQueryable<T>, Task<IEnumerable<T>>> Query { private get; set; }

        public async Task<IEnumerable<T>> CallAsync(IQueryable<T> set)
        {
            return await Query.Invoke(set);
        }
    }
}