using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Queries
{
    public class FirstOrDefaultAsyncQuery<T> : AsyncScalarQueryBase<T> where T : class
    {
        public FirstOrDefaultAsyncQuery(Expression<Func<T, bool>> where = null)
        {
            _query = s => s.FirstOrDefaultAsync(where);
        }
    }
}