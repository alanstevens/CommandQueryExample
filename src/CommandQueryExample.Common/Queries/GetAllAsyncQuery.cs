using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Queries
{
    public class GetAllAsyncQuery<T> : AsyncQueryBase<T> where T : class
    {
        public GetAllAsyncQuery()
        {
            _query = s => s.ToListAsync();
        }
    }
}