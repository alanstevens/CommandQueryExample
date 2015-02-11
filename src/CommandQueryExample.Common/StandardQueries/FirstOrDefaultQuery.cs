using System;
using System.Linq;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class FirstOrDefaultQuery<T> : BaseScalarQuery<T> where T : class
    {
        public FirstOrDefaultQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
            {
                _query = s => s.FirstOrDefault();
                return;
            }
            _query = s => s.FirstOrDefault(selector);
        }
    }
}