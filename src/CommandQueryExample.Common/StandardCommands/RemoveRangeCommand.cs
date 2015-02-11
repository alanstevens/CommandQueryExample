using System.Collections.Generic;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class RemoveRangeCommand<T> : BaseCommand<T> where T : class
    {
        public RemoveRangeCommand(IEnumerable<T> items)
        {
            _action = s =>
            {
                s.RemoveRange(items);
                foreach (var item in items)
                    MarkAsDeleted(item);
            };
        }
    }
}