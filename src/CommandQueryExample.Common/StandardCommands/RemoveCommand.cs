using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class RemoveCommand<T> : BaseCommand<T> where T : class
    {
        public RemoveCommand(T item)
        {
            Action = s =>
            {
                s.Remove(item);
                MarkAsDeleted(item);
            };
        }

        public RemoveCommand(params object[] keyValues)
        {
            Action = s =>
            {
                var item = s.Find(keyValues);
                Verify.NotNull(item, "item");
                s.Remove(item);
                MarkAsDeleted(item);
            };
        }
    }
}