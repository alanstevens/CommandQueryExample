using System;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class BaseCommand<T>
    {
        protected BaseCommand()
        {
            Action = x => { };
            MarkAsModified = x => x;
            MarkAsAdded = x => x;
            MarkAsDeleted = x => { };
        }

        public Func<T, T> MarkAsModified { get; set; }
        public Func<T, T> MarkAsAdded { get; set; }
        public Action<T> MarkAsDeleted { get; set; }

        protected Action<IQueryable<T>> Action { private get; set; }

        public void Execute(IQueryable<T> set)
        {
            Action.Invoke(set);
        }
    }
}