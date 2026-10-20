using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public string Greeting()
        {
            return "Chao mung cac ban den voi mon hoc";
        }

        public String Welcome(int id1, string name)
        {
            return $"Xin Chao {id1} - {name}, chuc ban hoc tot mon hoc nay hihi";
        }

        public IActionResult Welcome1(int numtimes, string name) {
            ViewBag.Id = numtimes;
            ViewData["Name"] = name;
            return View();
        }
    }
}
