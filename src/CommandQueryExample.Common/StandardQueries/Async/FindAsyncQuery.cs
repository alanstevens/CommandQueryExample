using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class FindAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public FindAsyncQuery(params object[] keyValues)
        {
            _query = s => s.FindAsync(keyValues);
        }
    }
}