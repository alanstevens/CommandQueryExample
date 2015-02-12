using System.Collections.Generic;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class AddRangeCommand<T> : BaseCommand<T> where T : class
    {
        public AddRangeCommand(IEnumerable<T> items)
        {
            Action = s =>
            {
                s.AddRange(items);
                foreach (var item in items)
                    MarkAsAdded(item);
            };
        }
    }
}