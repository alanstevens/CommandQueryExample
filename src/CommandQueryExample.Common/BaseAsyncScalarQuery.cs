using System;
using System.Linq;
using System.Threading.Tasks;

namespace CommandQueryExample.Common
{
    public abstract class BaseAsyncScalarQuery<T>
    {
        protected Func<IQueryable<T>, Task<T>> Query { private get; set; }

        public async Task<T> CallAsync(IQueryable<T> set)
        {
            return await Query.Invoke(set);
        }
    }
}