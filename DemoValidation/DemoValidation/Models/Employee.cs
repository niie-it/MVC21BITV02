using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
	public class Employee
	{
		public int? Id { get; set; }

		[StringLength(6, MinimumLength = 6, ErrorMessage ="Chính xác 6 kí tự")]
		public string EmployeeNo { get; set; }


		[DataType(DataType.Password)]
		public string Password { get; set; }


		[DataType(DataType.Password)]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }

		[StringLength(100, MinimumLength =3, ErrorMessage ="Từ 3 đến 100 kí tự")]
		public string FullName { get; set; }
		public string Email { get; set; }
		public string? Website { get; set; }
		public DateTime BirthDate { get; set; }
		public bool Gender { get; set; }
		public double Salary { get; set; }
		public string? Address { get; set; }
		public string Phone { get; set; }
		public string? CreditCard { get; set; }

		[DataType(DataType.MultilineText)]
		public string? Description { get; set; }
	}
}
