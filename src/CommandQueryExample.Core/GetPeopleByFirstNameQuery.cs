using System.Linq;
using CommandQueryExample.Common;
using CommandQuerySample.Domain;

namespace CommandQueryExample.Core
{
    public class GetPeopleByFirstNameQuery : BaseQuery<Person>
    {
        public GetPeopleByFirstNameQuery(string firstName)
        {
            Query = s => s.Where(x => x.FirstName == firstName).ToList();
        }
    }
}