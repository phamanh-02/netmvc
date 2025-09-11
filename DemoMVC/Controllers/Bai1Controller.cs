using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class Bai2Controllers : Controller
    {
        public IActionResult Index()
    {
        ViewBag.Message = "Hello";
        return View();
    }

    [HttpPost]
    public IActionResult Index(Bai1 ps)
    {
        ViewBag.Message = ps.FullName + " " + ps.Age;
        return View();
        }
    }

}