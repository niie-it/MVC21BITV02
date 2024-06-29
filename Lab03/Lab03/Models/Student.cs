using System.ComponentModel.DataAnnotations;

namespace Lab03.Models
{
    public class Student
    {
        [Display(Name = "Mã sinh viên")]
        public int Id { get; set; }

        [Display(Name = "Họ tên sinh viên")]
        public string Name { get; set; }

        [Display(Name = "Điểm")]
        public double Mark { get; set; }
        public string Photo { get; set; }
    }
}
