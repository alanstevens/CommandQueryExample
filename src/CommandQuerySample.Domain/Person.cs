using System.ComponentModel.DataAnnotations.Schema;

namespace CommandQuerySample.Domain
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
    }
}