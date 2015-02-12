using System;
using System.Linq;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class SingleOrDefaultQuery<T> : BaseScalarQuery<T> where T : class
    {
        public SingleOrDefaultQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
                Query = s => s.SingleOrDefault();
            Query = s => s.SingleOrDefault(selector);
        }
    }
}