using Microsoft.AspNetCore.Mvc;
using demomvc.Models;

namespace demomvc.Controllers{
    public class PersonController : Controller{
        public IActionResult Index (){
            return View();
//Tran Thi Kim Dung - 2021050135
        }
        [HttpPost]
        public IActionResult Index(Person ps){
            string str = "Hello " + ps.PersonID + " - " + ps.FullName.ToUpper();
            ViewBag.Tb= str;
            return View();
        }
    }
}