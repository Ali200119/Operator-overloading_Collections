using System;
namespace Domain.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		public int Salary { get; set; }

		public Employee(int id, string name, DateTime birthday, int salary)
		{
			Id = id;
			Name = name;
			Birthday = birthday;
			Salary = salary;
		}
    }
}