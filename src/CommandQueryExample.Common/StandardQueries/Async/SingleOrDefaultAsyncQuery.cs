using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class SingleOrDefaultAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public SingleOrDefaultAsyncQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
                Query = s => s.SingleOrDefaultAsync();
            Query = s => s.SingleOrDefaultAsync(selector);
        }
    }
}