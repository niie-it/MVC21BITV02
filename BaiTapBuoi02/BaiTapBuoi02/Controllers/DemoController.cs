using Microsoft.AspNetCore.Mvc;

namespace BaiTapBuoi02.Controllers
{
    public class DemoController : Controller
    {
        // /Demo/NhapThongTin
        public IActionResult NhapThongTin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult KetQua(string HoTen, int NamSinh)
        {
            ViewBag.HoTen = HoTen;
            ViewBag.NamSinh = NamSinh;

            return View();
        }
    }
}
