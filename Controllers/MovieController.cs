using Microsoft.AspNetCore.Mvc;

namespace adfs2.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}