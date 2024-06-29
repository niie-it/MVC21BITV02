using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class FileUpload : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile file)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", file.FileName);
            using (var newfile = new FileStream(filePath, FileMode.CreateNew))
            {
                file.CopyTo(newfile);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> files)
        {
            foreach (var file in files)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", file.FileName);
                using (var newfile = new FileStream(filePath, FileMode.CreateNew))
                {
                    file.CopyTo(newfile);
                }
            }

            return RedirectToAction("Index");
        }
    }
}
