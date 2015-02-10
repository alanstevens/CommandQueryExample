using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Commands
{
    public class AddCommand<T> : CommandBase<T> where T : class
    {
        public AddCommand(T item)
        {
            _action = s => s.Add(item); 
        }
    }
}