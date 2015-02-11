using CommandQueryExample.Common.Extensions;

namespace CommandQueryExample.Common.StandardQueries
{
    public class FindQuery<T> : BaseScalarQuery<T> where T : class
    {
        public FindQuery(params object[] keyValues)
        {
            _query = s => s.Find(keyValues);
        }
    }
}