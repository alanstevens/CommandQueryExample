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
            AttachIfNeeded = x => x;
            MarkAsModified = x => x;
        }

        public Func<T, T> AttachIfNeeded { get; set; }

        public Func<T, T> MarkAsModified { get; set; }

        public void Execute(IQueryable<T> set)
        {
            _action.Invoke(set);
        }
    }
}