using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace adfs2.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes = 1)
        {
            // Try /HelloWorld/Welcome?name=Tuyen&numTimes=5
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
        }

        // GET: /HelloWorld/Goodbye/
        public string Goodbye(string name, int ID = 1)
        {
            // Try /HelloWorld/Goodbye/5?name=Tuyen
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }        
    }
}