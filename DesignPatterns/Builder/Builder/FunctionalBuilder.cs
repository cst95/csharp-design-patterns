using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder
{
    public abstract class FunctionalBuilder<T, TSelf> 
        where T : new()
        where TSelf : FunctionalBuilder<T, TSelf>
    {
        private readonly List<Func<T,T>> _actions = new List<Func<T,T>>();

        protected TSelf Do(Action<T> action)
        {
            _actions.Add(p =>
            { 
                action(p);
                return p;
            });
            
            return (TSelf) this;
        }

        public T Build() => _actions.Aggregate(new T(), (person, action) => action(person));
    }

    public class FunctionEmployeeBuilder : FunctionalBuilder<Employee, FunctionEmployeeBuilder>
    {
        public FunctionEmployeeBuilder WorksAs(string job) => Do(e => e.Job = job);

        public FunctionEmployeeBuilder WithName(string name) => Do(e => e.Name = name);
        
        public FunctionEmployeeBuilder Earns(int salary) => Do(e => e.Salary = salary);
    }
}