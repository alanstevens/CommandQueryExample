using System;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class BaseScalarQuery<T>
    {
        protected Func<IQueryable<T>, T> _query;

        public virtual T Call(IQueryable<T> set)
        {
            return _query.Invoke(set);
        }
    }
}