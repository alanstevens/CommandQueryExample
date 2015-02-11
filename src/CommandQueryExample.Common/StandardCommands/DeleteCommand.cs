using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class DeleteCommand<T> : BaseCommand<T> where T : class
    {
        public DeleteCommand(T item)
        {
            _action = s =>
            {
                s.Delete(item);
                MarkAsDeleted(item);
            };
        }

        public DeleteCommand(object key)
        {
            _action = s =>
            {
                var item = s.Find(key);
                Verify.NotNull(item, "item");
                s.Delete(item);
                MarkAsDeleted(item);
            };
        }
    }
}