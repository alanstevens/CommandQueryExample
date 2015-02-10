using System.Collections.Generic;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Commands
{
    public class AddManyCommand<T> : CommandBase<T> where T : class
    {
        public AddManyCommand(IEnumerable<T> items)
        {
            _action = s => s.AddMany(items);
        }
    }
}