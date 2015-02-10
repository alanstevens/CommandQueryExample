using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommandQueryExample.Common.Queries
{
    public class SingleQuery<T> : ScalarQueryBase<T> where T : class
    {
        public SingleQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.Single(where);
        }
    }
}