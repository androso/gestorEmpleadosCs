using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Seniority { get; set; }
    }

    public class EmployeeManagement
    {
        private List<Employee> employees;

        public EmployeeManagement()
        {
            employees = new List<Employee>
            {
                new Employee
                {
                    Id = new Random().Next(),
                    FullName = "John Viber",
                    BirthDate = new DateTime(1990, 1, 1),
                    Seniority = "Junior"
                },
                new Employee
                {
                    Id = new Random().Next(),
                    FullName = "Jane Doe",
                    BirthDate = new DateTime(1985, 2, 2),
                    Seniority = "Mid"
                },
                new Employee
                {
                    Id = new Random().Next(),
                    FullName = "Alice Smith",
                    BirthDate = new DateTime(1980, 3, 3),
                    Seniority = "Senior"
                }
            };
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        
        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}