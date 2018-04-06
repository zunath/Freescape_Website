using Microsoft.AspNetCore.Mvc;

namespace Freescape.Web.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}