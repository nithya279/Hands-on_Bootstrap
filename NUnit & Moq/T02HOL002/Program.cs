using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02HOL002
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class EmployeeFunction
    {
        public List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id=99,Name="Nithin",Year=2015},
            new Employee(){Id=100,Name = "Radha",Year=2020},
            new Employee(){Id=101,Name="Nidharshana",Year=2020},
            new Employee(){Id=102,Name="Shri",Year=2016}
        };
        public IEnumerable<Employee> GetEmployees()
        {

            return this.employees;
        }
        public IEnumerable<Employee> GetEmployeesWhoHasJoinedPreviousYear()
        {
            return this.employees.Where(item => item.Year == 2020);
        }


    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
