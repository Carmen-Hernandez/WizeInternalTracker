using Microsoft.AspNetCore.Mvc;

namespace WizeTrackerSolution.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
