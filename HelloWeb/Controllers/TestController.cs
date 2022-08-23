using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Print(int limit)
        {
            return View(limit);
        }
    }
}
