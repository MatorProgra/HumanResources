using System;

namespace HumanResources
{
	public class Employee : IComparable<Employee>
	{
		public int Id { get; set; }
		public string FirsName { get; set; }
		public string LastName { get; set; }
		public decimal Salary { get; set; }
		public string Comments { get; set; }
		public bool IsEmployed { get; set; }
		public DateTime DateOfEmployment { get; set; }
		public DateTime? DateOfDismiss { get; set; }

		//public int IdState { get; set; }

		public int CompareTo(Employee other) => this.Id > other.Id ? 1 : -1;
	}
}
