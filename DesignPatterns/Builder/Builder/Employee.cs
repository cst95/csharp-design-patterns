using System;

namespace Builder
{
    public class Employee
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public DateTime StartTime { get; set; }

        public class Builder : InheritedBuilder.EmployeeSalaryBuilder<Builder>
        {
            internal Builder() {}
        }
        
        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Job)}: {Job}, {nameof(Salary)}: {Salary}";
        }
    }
}