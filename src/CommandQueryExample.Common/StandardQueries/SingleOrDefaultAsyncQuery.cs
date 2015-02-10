using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Queries
{
    public class SingleOrDefaultAsyncQuery<T> : AsyncScalarQueryBase<T> where T : class
    {
        public SingleOrDefaultAsyncQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.SingleOrDefaultAsync(where);
        }
    }
}