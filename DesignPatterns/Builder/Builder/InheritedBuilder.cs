namespace Builder
{
    public class InheritedBuilder
    {
        public abstract class EmployeeBuilder
        {
            protected Employee _employee = new Employee();

            public Employee Build() => _employee;
        }

        public class EmployeeJobBuilder<TSelf> : EmployeeBuilder
            where TSelf: EmployeeJobBuilder<TSelf>
        {
            public TSelf WorksAs(string job)
            {
                _employee.Job = job;
                return (TSelf) this;
            }
        }

        public class EmployeeNameBuilder<TSelf> : EmployeeJobBuilder<EmployeeNameBuilder<TSelf>>
            where TSelf: EmployeeNameBuilder<TSelf>
        {
            public TSelf WithName(string name)
            {
                _employee.Name = name;
                return (TSelf) this;
            }
        }

        public class EmployeeSalaryBuilder<TSelf> : EmployeeNameBuilder<EmployeeSalaryBuilder<TSelf>>
            where TSelf : EmployeeSalaryBuilder<TSelf>
        {
            public TSelf Earns(int salary)
            {
                _employee.Salary = salary;
                return (TSelf) this;
            }            
        }
    }
}