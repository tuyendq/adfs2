using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace adfs2.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        // GET: /Account/
        [AllowAnonymous]
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /Account/Welcome/
        [AllowAnonymous]
        public string Welcome()
        {
            return "This is Welcome action";
        }
        // [AllowAnonymous]
        // public ActionResult Login()
        // {
        // }

        
        // public ActionResult Logout()
        // {
        // }
    }
}