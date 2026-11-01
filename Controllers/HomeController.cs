using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var productos = new List<string>
        {
            "Laptop",
            "Mouse",
            "Teclado"
        };

        return View(productos);
    }
}