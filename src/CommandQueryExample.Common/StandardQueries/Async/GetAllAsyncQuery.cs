using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries.Async
{
    public class GetAllAsyncQuery<T> : BaseAsyncQuery<T> where T : class
    {
        public GetAllAsyncQuery()
        {
            Query = s => s.ToListAsync();
        }
    }
}