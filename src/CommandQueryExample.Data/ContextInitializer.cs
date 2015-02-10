using System.Data.Entity;
using CommandQuerySample.Domain;

namespace CommandQueryExample.Data
{
    public class ContextInitializer : DropCreateDatabaseAlways<SampleContext>
    {
        protected override void Seed(SampleContext context)
        {
            context.People.Add(new Person{FirstName = "Alan", LastName = "Stevens"});
        }
    }
}