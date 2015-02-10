using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Commands
{
    public class DeleteCommand<T> : CommandBase<T> where T : class
    {
        public DeleteCommand(T item)
        {
            _action = s => s.Delete(item);
        }

        public DeleteCommand(object key)
        {
            _action = s => s.Delete(key);
        }
    }
}