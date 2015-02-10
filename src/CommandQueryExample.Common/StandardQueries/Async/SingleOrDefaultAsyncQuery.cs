using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class SingleOrDefaultAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public SingleOrDefaultAsyncQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.SingleOrDefaultAsync(where);
        }
    }
}