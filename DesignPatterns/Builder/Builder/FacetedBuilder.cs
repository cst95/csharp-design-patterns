namespace Builder
{
    // Facade class
    public class FacetedEmployeeBuilder
    {
        protected Employee Employee  = new Employee();
        
        public EmployeeJobBuilder Job => new EmployeeJobBuilder(Employee);
        public EmployeeNameBuilder Name => new EmployeeNameBuilder(Employee);
        
        public static implicit operator Employee(FacetedEmployeeBuilder eb)
        {
            return eb.Employee;
        } 
    }

    public class EmployeeJobBuilder : FacetedEmployeeBuilder
    {
        public EmployeeJobBuilder(Employee employee)
        {
            Employee = employee;
        }
        
        public EmployeeJobBuilder WorksAs(string job)
        {
            Employee.Job = job;
            return this;
        }
    }

    public class EmployeeNameBuilder : FacetedEmployeeBuilder
    {
        public EmployeeNameBuilder(Employee employee)
        {
            Employee = employee;
        }

        public EmployeeNameBuilder Called(string name)
        {
            Employee.Name = name;
            return this;
        }
    }
}