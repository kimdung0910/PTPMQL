namespace demoMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using demoMvc.Models;
public class LuongController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
//Tran Thi Kim Dung - 2021050135
    [HttpPost]
    public IActionResult Sum(TinhLuong tl)
    {

        tl.TongLuong = tl.LuongCoBan * tl.HeSoLuong + tl.PhuCap;
        ViewBag.A="Luong=" +tl.TongLuong;
        return View("Index",tl);

    }
}