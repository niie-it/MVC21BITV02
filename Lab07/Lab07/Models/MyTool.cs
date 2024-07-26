namespace Lab07.Models
{
    public class MyTool
    {
        public static string UploadImageToFolder(IFormFile myFile, string folderName)
        {
            if(myFile == null) {  return string.Empty; }
            try
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", folderName, myFile.FileName);
                using (var newFile = new FileStream(fullPath, FileMode.CreateNew))
                {
                    myFile.CopyTo(newFile);
                }
                return myFile.FileName;
            } catch { return string.Empty; }
        }
    }
}
