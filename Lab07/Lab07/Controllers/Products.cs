using Lab07.Data;
using Lab07.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab07.Controllers
{
    public class Products : Controller
    {
        private readonly MvcNiieLabContext _context;

        public Products(MvcNiieLabContext context)
        {
            _context = context;
        }

        [HttpGet("/Products/{supplier_name}")]
        public IActionResult GetProductBySuppliers(string supplier_name)
        {
            var data = _context.Products
                .Where(p => p.Supplier.Name == supplier_name)
                .Select(p => new ProductBySupplierVM {
                    ProductId = p.Id,
                    ProductName = p.Name,
                    UnitPrice = p.UnitPrice,
                    Category = p.Category.Name
                });
            return View(data);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
