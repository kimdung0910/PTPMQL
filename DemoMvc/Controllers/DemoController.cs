using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
     //Khai bao cac phuong thuc
     //Tran Thi Kim Dung - 2021050135
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(string fName, string mEmail)
        {
            string strResult = "Hello " + fName + "-" + mEmail; // Sửa lỗi ở đây, đúng cách khai báo biến
            ViewBag.thongBao = strResult; // Sử dụng ViewBag để truyền dữ liệu đến View
            return View(); // Tạo một cái view tương ứng với action
        }
    }
}