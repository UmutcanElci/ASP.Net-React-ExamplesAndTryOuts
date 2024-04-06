using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMVCTutorial.Data;


namespace WebAppMVCTutorial.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
  

    
}