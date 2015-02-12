using System;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class BaseScalarQuery<T>
    {
        protected Func<IQueryable<T>, T> Query { private get; set; }

        public virtual T Call(IQueryable<T> set)
        {
            return Query.Invoke(set);
        }
    }
}