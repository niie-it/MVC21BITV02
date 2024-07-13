using Microsoft.AspNetCore.Mvc;

namespace L02WebApp.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Detail()
		{
			return View();
		}
	}
}
