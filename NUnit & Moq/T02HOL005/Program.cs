using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02HOL005
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeManager
    {
        private readonly List<Employee> employees;
        public int HeadCount { get; set; }
        public EmployeeManager()
        {
            employees = new List<Employee>();
            HeadCount = employees.Count;
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            HeadCount++;
        }
    }
}
