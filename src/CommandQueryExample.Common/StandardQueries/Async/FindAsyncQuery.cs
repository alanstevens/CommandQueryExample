using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class FindAsyncQuery<T> : BaseAsyncScalarQuery<T> where T : class
    {
        public FindAsyncQuery(params object[] keyValues)
        {
            Query = s => s.FindAsync(keyValues);
        }
    }
}