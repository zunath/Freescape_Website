using Microsoft.AspNetCore.Mvc;

namespace Freescape.Web.Controllers
{
    public class ForumsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}