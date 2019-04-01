using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lab2.Models;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Genre()
        {
            return View("~/Views/Genre/Index.cshtml");
        }

        [HttpGet]
        public IActionResult TVShow()
        {
            return View("~/Views/TVShow/Index.cshtml");
        }

        [HttpGet]
        public IActionResult ScheduleForWeek()
        {
            return View("~/Views/ScheduleForWeek/Index.cshtml");
        }

        [HttpPost]
        public string Genre(string name, string descriptions) {
            return "Жанр \"" + name + "\"" + " c описанием \"" + descriptions + "\" добавлен в базу";
        }

        [HttpPost]
        public string TVShow(string name, string duration, string rating, string description)
        {
            return "ТВ шоу \"" + name + "\" с длительностью " + duration + " мин. " + "c рейтингом " + rating + "% с описанием \"" + description + "\" добавлено в базу";
        }

        [HttpPost]
        public string ScheduleForWeek(string startTime, string guestsEmployees)
        {
            return "Расписание шоу, с началом в \"" + startTime + "\" и гостем \"" + guestsEmployees + "\" добавлено в базу";
        }

        [HttpPost]
        public string CitizenAppeal(string lfo, string organization, string goalOfRequest)
        {
            return "Обращение: ФИО" + lfo + "; Организация: " + organization + "; Цель обращения: " + goalOfRequest + " добавлено в базу";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
