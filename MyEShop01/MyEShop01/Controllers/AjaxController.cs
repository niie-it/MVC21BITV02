using Microsoft.AspNetCore.Mvc;
using MyEShop01.Entities;
using MyEShop01.Models;

namespace MyEShop01.Controllers
{
	public class AjaxController : Controller
	{
		private readonly MyEshopContext _context;

		public AjaxController(MyEshopContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ServerTime()
		{
			return Content(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
		}

		[HttpGet]
		public IActionResult Search()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Search(string? keyword)
		{
			var data = _context.HangHoas.AsQueryable();
			if (keyword != null)
			{
				data = data.Where(p => p.TenHh.Contains(keyword));
			}

			var result = data.Select(hh => new KetQuaTimKiemVM {
				MaHh = hh.Id,
				TenHh = hh.TenHh,
				DonGia = hh.DonGia.Value,
				NgaySX = hh.NgaySx,
				Loai = hh.MaLoaiNavigation.TenLoai
			}).ToList();

			return PartialView("TimKiemPartial", result);
		}
	}
}
