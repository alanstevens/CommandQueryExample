using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommandQueryExample.Common.Queries
{
    public class SingleOrDefaultQuery<T> : ScalarQueryBase<T> where T : class
    {
        public SingleOrDefaultQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.SingleOrDefault(where);
        }
    }
}