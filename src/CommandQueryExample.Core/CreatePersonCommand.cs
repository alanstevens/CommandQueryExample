using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;
using CommandQuerySample.Domain;

namespace CommandQueryExample.Core
{
    public class CreatePersonCommand : BaseCommand<Person>
    {
        public CreatePersonCommand(string firstName, string lastName)
        {
            Action = s => s.Add(new Person {FirstName = firstName, LastName = lastName});
        }
    }
}