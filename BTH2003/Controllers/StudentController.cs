using Microsoft.AspNetCore.Mvc;
using BTH2003.Models;
namespace BTH2003.Controllers;
public class StudentController : Controller
{
    private readonly ApplicationDbContext BTH2003
    public StudentController (ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var model = await _context.Studnets.ToListAsync();
        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Student std)
  {
    if(ModelState.IsValid)
    {
        _context.Add(std);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    return View(std);
  }
}



