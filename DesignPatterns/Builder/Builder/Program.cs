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

            Console.WriteLine(person2);
            
            // Functional Builder Pattern
            var fb = new FunctionEmployeeBuilder();
            var person3 = fb
                .WithName("Charlie")
                .WorksAs("Developer")
                .Earns(1000)
                .Build();

            Console.WriteLine(person3);
        }
    }
}