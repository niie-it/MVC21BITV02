using Lab07.Data;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Controllers
{
	public class SuppilersController : Controller
	{
		private readonly MvcNiieLabContext _context;

		public SuppilersController(MvcNiieLabContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var data = _context.Suppliers.ToList();
			return View(data);
		}
	}
}
