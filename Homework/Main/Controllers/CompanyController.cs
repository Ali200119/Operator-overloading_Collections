using System;
using Domain.Models;
using Service.Interfaces;
using Service.Services;

namespace Main.Controllers
{
	public class CompanyController
	{
		private readonly ICompany _companyService;

		public CompanyController()
		{
			_companyService = new CompanyService();
		}

		public void Show() => Console.WriteLine(_companyService.Count(GetEmployees(), new DateTime(1993, 01, 10), new DateTime (2002, 10, 07), 2000));

		private List<Employee> GetEmployees()
		{
			Employee employee1 = new Employee(1, "Ali", new DateTime (2001, 08, 19), 2500);
            Employee employee2 = new Employee(2, "Cavid", new DateTime(1993, 04, 12), 3000);
            Employee employee3 = new Employee(3, "Dexter", new DateTime(2000, 08, 19), 2000);
            Employee employee4 = new Employee(4, "Sarah", new DateTime(1990, 08, 19), 2300);

			return new List<Employee> { employee1, employee2, employee3, employee4 };
        }
	}
}