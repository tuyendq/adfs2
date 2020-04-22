using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace adfs2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is {numTimes}");
        }
    }
}