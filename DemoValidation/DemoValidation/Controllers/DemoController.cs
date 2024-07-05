using DemoValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
	public class DemoController : Controller
	{
		public IActionResult SinhVien()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SinhVien(Student model)
		{
			if (!ModelState.IsValid)
			{
				ModelState.AddModelError("loi", "Còn lỗi");
			}
			return View();
		}
	}
}
