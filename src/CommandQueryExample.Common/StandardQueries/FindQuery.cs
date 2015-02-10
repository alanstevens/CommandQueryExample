using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.Queries
{
    public class FindQuery<T> : ScalarQueryBase<T> where T : class
    {
        public FindQuery(object id)
        {
            _query = s => s.Find(id);
        }
    }
}