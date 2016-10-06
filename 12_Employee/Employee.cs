using System.Collections.Generic;

namespace _12_Employee
{
    internal class Employee
    {

        public Employee(long id, string v1, string v2)
        {
            Name = v1;
            Type = v2;
            Id = id;
        }

        public long Id { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
    }
}