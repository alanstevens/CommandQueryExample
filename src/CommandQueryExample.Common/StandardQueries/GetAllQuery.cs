using System.Linq;

namespace CommandQueryExample.Common.Queries
{
    public class GetAllQuery<T> : QueryBase<T> where T : class
    {
        public GetAllQuery()
        {
            _query = s => s.AsEnumerable();
        }
    }
}