using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class AddCommand<T> : CommandBase<T> where T : class
    {
        public AddCommand(T item)
        {
            _action = s =>
            {
                s.Add(item);
                MarkAsAdded(item);
            };
        }
    }
}