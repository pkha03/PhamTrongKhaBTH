using Microsoft.AspNetCore.Mvc;
using _2003.Models;
namespace _2003.Controllers;
public class StudentController : Controller
{

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
public IActionResult Create(Student std)
{
    string kq = std.StudentCode + "-" + std.FullName + "-" + std.Address;
    ViewBag.Khaa=kq;
    return View();
}
}



