using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models; 
namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
//Tran Thi Kim Dung - 2021050135
        [HttpPost]
        public IActionResult Index(Student std)
        {
            string str = "Hello " + std.StudentID + "-" + std.FullName;
            ViewBag.thongBao = str;
            return View();
        }
    }
}