using Microsoft.AspNetCore.Mvc;

namespace DemoLayout.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
