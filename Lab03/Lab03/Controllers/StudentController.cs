using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			return View(new Student());
		}

		string studentFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "student.json");

		[HttpPost]
		public IActionResult Manage(Student student, IFormFile myfile)
		{
			if (myfile != null)
			{
				var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", myfile.FileName);
				using(var f = new FileStream(fullPath, FileMode.CreateNew))
				{
					myfile.CopyTo(f);
				}
				student.Photo = myfile.FileName;
			}

			var jsonStr = System.Text.Json.JsonSerializer.Serialize(student);
			System.IO.File.WriteAllText(studentFile, jsonStr);
			return View("Index", student);
		}


		public IActionResult ReadStudent()
		{
			var jsonStr = System.IO.File.ReadAllText(studentFile);
			var student = System.Text.Json.JsonSerializer.Deserialize<Student>(jsonStr);

			return View("Index", student);
		}
	}
}
