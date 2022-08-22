using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public string Test()
    {
        return "Hello there!!!";
    }
}
