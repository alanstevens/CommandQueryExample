using System;
using System.Linq;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class WhereAsyncQuery<T> : BaseAsyncQuery<T> where T : class
    {
        public WhereAsyncQuery(Expression<Func<T, bool>> selector)
        {
            _query = s => s.Where(selector).ToListAsync();
        }
    }
}