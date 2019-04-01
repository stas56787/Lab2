using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class TVShowController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}