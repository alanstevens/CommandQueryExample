using System;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class BaseCommand<T>
    {
        protected BaseCommand()
        {
            MarkAsModified = x => x;
            MarkAsAdded = x => x;
            MarkAsDeleted = x => { };
        }

        protected Action<IQueryable<T>> _action = x => { };

        public Func<T, T> MarkAsModified { get; set; }
        public Func<T, T> MarkAsAdded { get; set; }
        public Action<T> MarkAsDeleted { get; set; }

        public void Execute(IQueryable<T> set)
        {
            _action.Invoke(set);
        }
    }
}