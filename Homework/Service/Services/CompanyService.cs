using System;
using Domain.Models;
using Service.Interfaces;

namespace Service.Services
{
    public class CompanyService : ICompany
    {
        public int Count(List<Employee> employees, DateTime date1, DateTime date2, int salary)
        {
            return employees.FindAll(e => e.Birthday > date1 && e.Birthday < date2 && e.Salary > salary).Count();

            //int count = 0;

            //foreach (Employee employee in employees)
            //{
            //    if (employee.Birthday > date1 && employee.Birthday < date2 && employee.Salary > salary)
            //    {
            //        count++;
            //    }
            //}

            //return count;
        }
    }
}