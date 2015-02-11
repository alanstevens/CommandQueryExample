using System.Collections.Generic;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class AddManyCommand<T> : BaseCommand<T> where T : class
    {
        public AddManyCommand(IEnumerable<T> items)
        {
            _action = s =>
            {
                s.AddMany(items);
                foreach (var item in items)
                    MarkAsAdded(item);
            };
        }
    }
}