using System.Collections.Generic;

namespace CommandQueryExample.Common.StandardCommands
{
    public class UpdateRangeCommand<T> : BaseCommand<T> where T : class
    {
        public UpdateRangeCommand(IEnumerable<T> items)
        {
            _action = s =>
            {
                foreach (var item in items)
                    MarkAsModified(item);
            };
        }
    }
}