using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class CardController : Controller
    {
        public IActionResult CreateCard()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
