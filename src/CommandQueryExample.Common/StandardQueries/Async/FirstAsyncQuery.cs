using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class FirstAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public FirstAsyncQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
                Query = s => s.FirstAsync();
            Query = s => s.FirstAsync(selector);
        }
    }
}