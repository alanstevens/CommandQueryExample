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
                _query = s => s.SingleAsync();
            _query = s => s.SingleAsync(selector);
        }
    }
}