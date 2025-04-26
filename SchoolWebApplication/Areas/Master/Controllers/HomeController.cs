using Microsoft.AspNetCore.Mvc;

namespace SchoolWebApplication.Areas.Master.Controllers
{
    [Area("Master")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
