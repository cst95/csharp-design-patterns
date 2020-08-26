using System;
using Builder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fluent Builder Pattern
            var eb = new EmployeeBuilder();

            var person = eb
                .WithName("Charlie")
                .Earns(1000)
                .WorksAs("Developer")
                .Build();

            Console.WriteLine(person);
            
            // Inherited Builder Pattern
           
            var person2 = Employee.New
                .WorksAs("Developer")
                .WithName("Charlie")
                .Earns(12000)
                .Build();

        }
    }
}