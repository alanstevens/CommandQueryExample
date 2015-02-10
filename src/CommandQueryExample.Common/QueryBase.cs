using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class QueryBase<T> where T : class
    {
        protected Func<IQueryable<T>, IEnumerable<T>> _query;

        public IEnumerable<T> Call(IQueryable<T> set)
        {
            return _query.Invoke(set);
        }
    }
}