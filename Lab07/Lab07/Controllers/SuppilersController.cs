using Lab07.Data;
using Lab07.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

		#region Create Supplier
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Create(Supplier model, IFormFile FileLogo)
        {
			try
			{
				model.Logo = MyTool.UploadImageToFolder(FileLogo, "Suppliers");
				_context.Add(model);
				_context.SaveChanges();
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
			}
            return View();
        }
        #endregion
    }
}
