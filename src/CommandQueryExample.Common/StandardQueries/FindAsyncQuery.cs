using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Queries
{
    public class FindAsyncQuery<T> : AsyncScalarQueryBase<T> where T : class
    {
        public FindAsyncQuery(object id)
        {
            _query = s => s.FindAsync(id);
        }
    }
}