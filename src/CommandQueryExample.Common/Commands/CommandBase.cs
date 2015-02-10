using System;
using System.Linq;

namespace CommandQueryExample.Common.Commands
{
    public abstract class CommandBase<T>
    {
        // ReSharper disable FieldCanBeMadeReadOnly.Local
        protected Action<IQueryable<T>> _action = x => { };
        // ReSharper restore FieldCanBeMadeReadOnly.Local

        protected CommandBase()
        {
            MarkAsModified = x => x;
            MarkAsAdded = x => x;
            MarkAsDeleted = x => {};
        }


        public Func<T, T> MarkAsModified { get; set; }
        public Func<T, T> MarkAsAdded { get; set; }
        public Action<T> MarkAsDeleted { get; set; }

        public void Execute(IQueryable<T> set)
        {
            _action.Invoke(set);
        }
    }
}