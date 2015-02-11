using System;
using System.Linq;
using System.Linq.Expressions;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class FirstQuery<T> : BaseScalarQuery<T> where T : class
    {
        public FirstQuery(Expression<Func<T, bool>> selector = null)
        {
            if (selector.IsNull())
            {
                _query = s => s.First();
                return;
            }
            _query = s => s.First(selector);
        }
    }
}