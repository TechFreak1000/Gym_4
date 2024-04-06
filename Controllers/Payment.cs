using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    public class Payment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateP()
        {
            return View();
        }

        public IActionResult PaymentGateway()
        {
            return View();
        }
    }
}
