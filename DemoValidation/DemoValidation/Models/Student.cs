using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
	public class Student
	{
		[Display(Name = "Họ tên")]
		[MinLength(5, ErrorMessage ="Tối thiểu 5 kí tự")]
		public string FullName { get; set; }

		[Display(Name ="Tuổi")]
		[Range(16, 65, ErrorMessage ="Tuổi từ 16 đến 65")]
		public int Age { get; set; }
	}
}
