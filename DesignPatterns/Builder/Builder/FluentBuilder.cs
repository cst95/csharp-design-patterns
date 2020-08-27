using System;

namespace Builder
{
    public class EmployeeBuilder
    {
        private readonly Employee _employee = new Employee();

        public EmployeeBuilder WithName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder WorksAs(string job)
        {
            _employee.Job = job;
            return this;
        }

        public EmployeeBuilder Earns(int salary)
        {
            _employee.Salary = salary;
            return this;
        }

        public Employee Build() => _employee;
    }
}