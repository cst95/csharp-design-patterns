namespace Builder
{
    public class InheritedBuilder
    {
        public abstract class EmployeeBuilder
        {
            protected readonly Employee Employee = new Employee();

            public Employee Build() => Employee;
        }

        public class EmployeeJobBuilder<TSelf> : EmployeeBuilder
            where TSelf: EmployeeJobBuilder<TSelf>
        {
            public TSelf WorksAs(string job)
            {
                Employee.Job = job;
                return (TSelf) this;
            }
        }

        public class EmployeeNameBuilder<TSelf> : EmployeeJobBuilder<EmployeeNameBuilder<TSelf>>
            where TSelf: EmployeeNameBuilder<TSelf>
        {
            public TSelf WithName(string name)
            {
                Employee.Name = name;
                return (TSelf) this;
            }
        }

        public class EmployeeSalaryBuilder<TSelf> : EmployeeNameBuilder<EmployeeSalaryBuilder<TSelf>>
            where TSelf : EmployeeSalaryBuilder<TSelf>
        {
            public TSelf Earns(int salary)
            {
                Employee.Salary = salary;
                return (TSelf) this;
            }            
        }
    }
}