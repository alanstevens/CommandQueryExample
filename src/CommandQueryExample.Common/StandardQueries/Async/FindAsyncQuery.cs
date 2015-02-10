using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class FindAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public FindAsyncQuery(object id)
        {
            _query = s => s.FindAsync(id);
        }
    }
}