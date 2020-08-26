using System;

namespace Builder.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var eb = new EmployeeBuilder();

            var person = eb
                .WithName("Charlie")
                .WithSalary(1000)
                .WorksAs("Developer")
                .Build();

            Console.WriteLine(person);
        }
    }
}