using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class FindQuery<T> : BaseScalarQuery<T> where T : class
    {
        public FindQuery(object id)
        {
            _query = s => s.Find(id);
        }
    }
}