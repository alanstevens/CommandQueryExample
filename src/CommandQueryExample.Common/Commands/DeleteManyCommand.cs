using System.Collections;
using System.Collections.Generic;
using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Commands
{
    public class DeleteManyCommand<T> : CommandBase<T> where T : class
    {
        public DeleteManyCommand(IEnumerable<T> items)
        {
            _action = s => s.DeleteMany(items);
        }
    }
}