using demomvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demomvc.Controllers;
public class EmployeeController : Controller{
    public IActionResult Index(){
        return View();
//Tran Thi Kim Dung - 2021050135
    }
    [HttpPost]
     public IActionResult Index(Employee emp){
        string  str = "hello " + emp.EmployeeID + "-" + emp.FullName;
        ViewBag.L=str;
        return View();

    }
    
}