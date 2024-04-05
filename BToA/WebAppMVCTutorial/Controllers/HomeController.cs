using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVCTutorial.Data;


namespace WebAppMVCTutorial.Controllers;

public class HomeController : Controller
{
    private readonly MenuContext _context;

    public HomeController(MenuContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Dishes.ToListAsync());
    }
}