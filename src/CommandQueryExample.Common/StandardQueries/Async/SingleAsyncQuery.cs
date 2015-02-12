using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class SingleAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public SingleAsyncQuery(Expression<Func<T, bool>> selector)
        {
            if (selector.IsNull())
                Query = s => s.SingleAsync();
            Query = s => s.SingleAsync(selector);
        }
    }
}