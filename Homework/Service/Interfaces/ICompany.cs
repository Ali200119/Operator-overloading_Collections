using System;
using Domain.Models;

namespace Service.Interfaces
{
	public interface ICompany
	{
		int Count(List<Employee> employees, DateTime date1, DateTime date2, int salary);
	}
}