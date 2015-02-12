using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class AddCommand<T> : BaseCommand<T> where T : class
    {
        public AddCommand(T item)
        {
            Action = s =>
            {
                s.Add(item);
                MarkAsAdded(item);
            };
        }
    }
}