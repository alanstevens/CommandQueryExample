using System;
using System.Linq;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class SingleQuery<T> : BaseScalarQuery<T> where T : class
    {
        public SingleQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
                _query = s => s.Single();
            _query = s => s.Single(selector);
        }
    }
}