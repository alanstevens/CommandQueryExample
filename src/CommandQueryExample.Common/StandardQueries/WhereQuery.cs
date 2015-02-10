using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class WhereQuery<T> : QueryBase<T> where T : class
    {
        public WhereQuery(Expression<Func<T, bool>> where)
        {
            _query = s => s.Where(where).ToList();
        }
    }
}