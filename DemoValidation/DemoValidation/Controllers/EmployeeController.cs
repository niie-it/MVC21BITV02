using DemoValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(Employee model)
		{
			if (!ModelState.IsValid)
			{
				ModelState.AddModelError("loi", "Còn lỗi");
			}
			return View();
		}
	}
}
