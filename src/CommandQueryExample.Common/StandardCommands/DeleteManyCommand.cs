using System.Collections.Generic;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardCommands
{
    public class DeleteManyCommand<T> : BaseCommand<T> where T : class
    {
        public DeleteManyCommand(IEnumerable<T> items)
        {
            _action = s =>
            {
                s.DeleteMany(items);
                foreach (var item in items)
                    MarkAsDeleted(item);
            };
        }
    }
}