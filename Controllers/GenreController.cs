using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class GenreController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}