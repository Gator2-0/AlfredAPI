using Microsoft.AspNetCore.Mvc;

namespace AfredAPI.Controllers
{
    public class DivingControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
