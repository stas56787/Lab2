using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class ScheduleForWeekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}