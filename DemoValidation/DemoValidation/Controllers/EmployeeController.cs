using DemoValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
	public class EmployeeController : Controller
	{
		public IActionResult CheckExistedEmployee(string EmployeeNo)
		{
			var dsMaNV = new List<string> { "admin", "tep" };
			if (dsMaNV.Contains(EmployeeNo))
			{
				return Json($"Mã <b>{EmployeeNo}</b> đã có");
			}
			return Json(true);
		}

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
