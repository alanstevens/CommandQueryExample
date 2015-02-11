using System;
using System.Collections.Generic;
using CommandQueryExample.Common;
using CommandQueryExample.Common.Extensions;
using CommandQueryExample.Common.StandardCommands;
using CommandQueryExample.Core;
using CommandQueryExample.Data;
using CommandQuerySample.Domain;

namespace CommandQueryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // These tasks are usually handled by my IoC bootstrapper
            new QueryExtensionsUtil().OnStartup();
            new CommandExtensionsUtil().OnStartup();
            new SumAsyncExtensionsUtil().OnStartup();
            new AverageAsyncExtensionsUtil().OnStartup();
            new DataContextFactoryStartupTask().OnStartup();

            // this would normally be injected on the constructor
            IDispatcher dispatcher = new Dispatcher();

            using (var context = DataContextFactory.CreateDataContext())
            {
                var query = new GetPeopleByFirstNameQuery("Alan");
                PrintPeople(dispatcher.Get(query));

                var command = new AddCommand<Person>(new Person {FirstName = "Alan", LastName = "Turing"});
                dispatcher.QueueCommand(command);

                var mutableAlan = new Person {FirstName = "Alan", LastName = "Shepard"};

                dispatcher.Add(mutableAlan); // Using an IDispatcher extension method

                context.SaveChanges();

                PrintPeople(dispatcher.Get(query));

                mutableAlan.LastName = "Alda";
                dispatcher.QueueCommand(new UpdateCommand<Person>(mutableAlan)); // Not strictly needed

                PrintPeople(dispatcher.Get(query));

                dispatcher.QueueCommand(new RemoveCommand<Person>(mutableAlan));

                context.SaveChanges();

                PrintPeople(dispatcher.Get(query));
            }
            Console.Read();
        }

        static void PrintPeople(IEnumerable<Person> people)
        {
            foreach (var person in people)
                Console.WriteLine(person.FullName);

            Console.WriteLine();
        }
    }
}