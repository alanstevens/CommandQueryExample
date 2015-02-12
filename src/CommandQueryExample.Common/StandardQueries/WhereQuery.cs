using System;
using System.Linq;
using System.Linq.Expressions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class WhereQuery<T> : BaseQuery<T> where T : class
    {
        public WhereQuery(Expression<Func<T, bool>> selector)
        {
            Query = s => s.Where(selector).ToList();
        }
    }
}