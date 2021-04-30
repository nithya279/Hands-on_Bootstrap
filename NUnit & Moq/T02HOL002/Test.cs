using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace T02HOL002
{

    [TestFixture]
    public class Test
    {
        [Test]
        public void CheckIfAnyNullValueIsAvailable()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            Assert.That(employeeFunction.GetEmployees(), !Is.Null);
        }
        [Test]
        public void CheckIfAnyPersonsIdIs100()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            var people = employeeFunction.GetEmployees();
            Assert.That(people.Any(p => p.Id == 100));
        }
        [Test]
        public void CheckIfAllDataAreUniqueBasedOnId()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            IEnumerable<Employee> employees = employeeFunction.GetEmployees();
            Assert.That(employees.Select(item => item.Id), Is.Unique);
        }
        [Test]
        public void GetEmployeesWhoJoinedInPreviousYears()
        {
            EmployeeFunction employeeFunction = new EmployeeFunction();
            IEnumerable<Employee> employees = employeeFunction.GetEmployees();
            IEnumerable<Employee> employees1 = employeeFunction.GetEmployeesWhoHasJoinedPreviousYear();
            Assert.That(employees, !Is.EqualTo(employees1));
        }
    }
}
