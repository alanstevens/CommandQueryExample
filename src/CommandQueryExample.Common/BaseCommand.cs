using System;
using System.Linq;

namespace CommandQueryExample.Common
{
    public abstract class BaseCommand<T>
    {
        protected BaseCommand()
        {
            MarkAsModified = x => { };
            MarkAsAdded = x => { };
            MarkAsDeleted = x => { };
        }

        public Action<T> MarkAsModified { get; set; }
        public Action<T> MarkAsAdded { get; set; }
        public Action<T> MarkAsDeleted { get; set; }

        protected Action<IQueryable<T>> Action { private get; set; }

        public void Execute(IQueryable<T> set)
        {
            Action.Invoke(set);
        }
    }
}