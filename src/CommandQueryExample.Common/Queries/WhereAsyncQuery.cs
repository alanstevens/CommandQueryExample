using System;
using System.Linq;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Queries
{
    public class WhereAsyncQuery<T> : AsyncQueryBase<T> where T : class
    {
        public WhereAsyncQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.Where(where).ToListAsync();
        }
    }
}