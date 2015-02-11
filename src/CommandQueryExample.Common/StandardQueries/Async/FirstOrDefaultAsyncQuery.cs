using System;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class FirstOrDefaultAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public FirstOrDefaultAsyncQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
                _query = s => s.FirstOrDefaultAsync();
            _query = s => s.FirstOrDefaultAsync(selector);
        }
    }
}