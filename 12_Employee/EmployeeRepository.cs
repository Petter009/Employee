using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Employee
{
    internal class EmployeeRepository
    {
        private long id;
        public List<Employee> emplist;
        public EmployeeRepository()
        {
           emplist = new List<Employee>();
        }
        internal void Clear()
        {
           emplist.Clear() ;
        }

        public long NextId()
        {
            id++;
            return id;
        }

        internal int CountEmployees()
        {
            return emplist.Count ;
        }

        internal Employee CreateEmployee(string v1, string v2)
        {
            NextId();
            Employee emp = new Employee(id, v1, v2);
            emplist.Add(emp);
            return emp;
        }

        internal void SaveEmployee(Employee simon)
        {
            NextId();
            Employee emp = new Employee(simon.Id, simon.Name, simon.Type);
        }

        internal Employee LoadEmployee(long id)
        {
            return emplist.Find(x => x.Id == id);
        }

        internal List<Employee> FindAllEmployees()
        {
            return emplist;
        }
    }
}