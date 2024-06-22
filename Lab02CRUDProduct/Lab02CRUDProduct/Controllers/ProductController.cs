using Lab02CRUDProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab02CRUDProduct.Controllers
{
	public class ProductController : Controller
	{
		static List<Product> products = new List<Product>()
		{
			new Product{ID=1, Name="IPad Pro", Price=1129},
			new Product{ID=2, Name="IPhone 15", Price=1399},
			new Product{ID=3, Name="IPad Mini 6", Price=1099},
		};

		public IActionResult Index()
		{
			return View(products);
		}

		public IActionResult Edit(int id)
		{
			var existedProduct = GetProduct(id);
			return View();
		}

		public IActionResult Delete(int proid)
		{
			var existedProduct = GetProduct(proid);
			if(existedProduct != null)
			{
				products.Remove(existedProduct);
			}
			return RedirectToAction("Index");
		}

		private Product? GetProduct(int id)
		{
			return products.SingleOrDefault(p => p.ID == id);
		}
	}
}
