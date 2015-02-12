using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class BaseQuery<T> where T : class
    {
        protected Func<IQueryable<T>, IEnumerable<T>> Query { private get; set; }

        public IEnumerable<T> Call(IQueryable<T> set)
        {
            return Query.Invoke(set);
        }
    }
}