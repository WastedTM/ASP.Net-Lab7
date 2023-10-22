using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace lab7.Controllers;

public class FileController : Controller
{
    // GET: /File/DownloadFile
    public ActionResult DownloadFile()
    {
        return View();
    }

    // POST: /File/DownloadFile
    [HttpPost]
    public IActionResult DownloadFile(string firstName, string lastName, string fileName)
    {
        if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrWhiteSpace(fileName))
        {
            string content = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            byte[] fileContents = Encoding.UTF8.GetBytes(content);
            string mimeType = "text/plain";

            return File(fileContents, mimeType, fileName + ".txt");
        }
        return View();
    }
}