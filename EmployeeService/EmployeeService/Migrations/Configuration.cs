namespace EmployeeService.Migrations
{
    using EmployeeService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeService.Data.EmployeeServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EmployeeService.Data.EmployeeServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            
                context.Departments.AddOrUpdate(
                  p => p.Id,
                  new Department() { Id=100,Name = "HR" },
                  new Department() {Id=101,Name = "Technical" }
                 
                );
            context.Employees.AddOrUpdate(
                  p => p.Id,
                  new Employee() { Id = 1, FirstName = "John",LastName="Smith",DepartmentId=101,Salary=30000 },
                  new Employee() { Id = 1, FirstName = "Mary", LastName = "Jane", DepartmentId = 101, Salary = 20000 },
                  new Employee() { Id = 1, FirstName = "Steve", LastName = "Lopez", DepartmentId = 101, Salary = 50000 }

                );

        }
    }
}
