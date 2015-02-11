using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class RemoveCommand<T> : BaseCommand<T> where T : class
    {
        public RemoveCommand(T item)
        {
            _action = s =>
            {
                s.Remove(item);
                MarkAsDeleted(item);
            };
        }

        public RemoveCommand(object key)
        {
            _action = s =>
            {
                var item = s.Find(key);
                Verify.NotNull(item, "item");
                s.Remove(item);
                MarkAsDeleted(item);
            };
        }
    }
}