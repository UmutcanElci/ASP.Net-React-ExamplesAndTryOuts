using Microsoft.AspNetCore.Mvc;

namespace ReactAsp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = new List<string> { "P1", "P2", "P3" };
        return Ok(products);
    }
}