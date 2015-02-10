using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class SingleOrDefaultQuery<T> : BaseScalarQuery<T> where T : class
    {
        public SingleOrDefaultQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.SingleOrDefault(where);
        }
    }
}