using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class PhuongtrinhB1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
//Tran Thi Kim Dung - 2021050135
        public IActionResult Index(double a, double b)
        {
            if (a==0)
            {
                if (b==0)
                {
                    ViewBag.ThongBao = "Phuong Trinh Co Vo So Nghiem";
                }else{
                    ViewBag.ThongBao = "Phuong Trinh Vo Nghiem";
                }
            }else{
                double x = -b/a;
                ViewBag.ThongBao = $"Phuong trinh co nghiem la: x = {x}";
            }
            
             return View();
        }        
    }
}

    