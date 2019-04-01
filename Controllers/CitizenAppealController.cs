using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class CitizenAppealController : Controller
    {
        public IActionResult Index()
        {
            return Content("<html></html>");
        }
    }
}