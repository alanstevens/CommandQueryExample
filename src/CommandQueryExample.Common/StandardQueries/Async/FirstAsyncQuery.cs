using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class FirstAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public FirstAsyncQuery(Expression<Func<T, bool>> where = null)
        {
            _query = s => s.FirstAsync(where);
        }
    }
}