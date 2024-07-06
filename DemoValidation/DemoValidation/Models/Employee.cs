using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
    public class Employee
    {
        public int? Id { get; set; }

        [StringLength(6, MinimumLength = 2, ErrorMessage = "Từ 2 đến 6 kí tự")]
        [Remote(action: "CheckExistedEmployee", controller: "Employee")]
        public string EmployeeNo { get; set; }


        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Tối thiểu 6 kí tự")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Từ 3 đến 100 kí tự")]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string? Website { get; set; }

        [DataType(DataType.Date)]
        [EnoughAgeForWork]
        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; }

        [Range(0, double.MaxValue)]
        public double Salary { get; set; }

        public string? Address { get; set; }

        [RegularExpression(@"0[98753]\d{8}")]
        public string Phone { get; set; }

        [CreditCard]
        public string? CreditCard { get; set; }


        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}
