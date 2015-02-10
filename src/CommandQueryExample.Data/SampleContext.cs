using System.Data.Entity;
using CommandQuerySample.Domain;

namespace CommandQueryExample.Data
{
    public class SampleContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}